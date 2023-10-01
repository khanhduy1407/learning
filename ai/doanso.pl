:- dynamic(answer/1).
:- dynamic(guesses/1).

% Số lần đoán tối đa là 7 lần
max_guesses(8).

% Khởi tạo trò chơi
start_game :-
    retractall(answer(_)),
    retractall(guesses(_)),
    assertz(guesses(0)),
    random(1, 100, X),
    assertz(answer(X)),
    nl,
    write('*********************************'), nl,
    write('  Tro choi doan so bat dau!'), nl,
    write('  Bob da chon mot so tu 1 den 100.'), nl,
    write('  Ban hay doan so do.'), nl,
    write('*********************************'), nl,
    play_game.

% Bắt đầu chơi
play_game :-
    guesses(N),
    max_guesses(Max),
    N < Max,
    write('*********************************'), nl,
    write('  Lan doan thu '), write(N), nl,
    write('  Nhap so cua ban: '),
    read(Guess),
    process_guess(Guess),
    play_game.
play_game :-
    guesses(N),
    max_guesses(Max),
    N =:= Max,
    write('*********************************'), nl,
    write('  Ban da het so lan doan. So cua Bob chon la: '),
    answer(Answer),
    write(Answer), nl,
    write('  Chuc ban may man lan sau!'), nl,
    write('*********************************'), nl,
    restart_game.

% Xử lý lựa chọn của người chơi
process_guess(Guess) :-
    answer(Answer),
    Guess =:= Answer,
    write('  *********************************'), nl,
    write('  Chuc mung ban da doan dung so cua Bob!'), nl,
    write('  *********************************'), nl,
    restart_game.
process_guess(Guess) :-
    answer(Answer),
    Guess < Answer,
    write('  So cua Bob lon hon '), write(Guess), nl,
    increment_guesses,
    play_game.
process_guess(Guess) :-
    answer(Answer),
    Guess > Answer,
    write('  So cua Bob nho hon '), write(Guess), nl,
    increment_guesses,
    play_game.

% Tăng số lần đoán
increment_guesses :-
    retract(guesses(N)),
    N1 is N + 1,
    assertz(guesses(N1)).

% Hàm siêu AI thong minh sử dụng phương pháp "người chơi ảo"
super_smart_ai_guess(Answer, Min, Max, Guess) :-
    virtual_player_guess(Min, Max, Answer, Guess).

% Phương pháp "người chơi ảo" đoán số thông minh hơn
virtual_player_guess(Min, Max, Answer, Guess) :-
    RemainingGuesses is Max - Min + 1,
    RandomPercentage is random(101),
    (RandomPercentage =< RemainingGuesses -> % Sử dụng phương pháp ngẫu nhiên một phần thời gian
        random(Min, Max, Guess)
    ;
        % Sử dụng tối ưu hóa thông minh dựa trên phân phói
        Mid is (Min + Max) // 2,
        (Mid =:= Answer -> Guess = Mid ; Guess is Mid + (Answer - Mid) // 2)
    ).

% Chạy trò chơi với AI thông minh
play_game_smart_ai :-
    guesses(N),
    max_guesses(Max),
    N < Max,
    answer(Answer),
    super_smart_ai_guess(Answer, 1, 100, Guess),
    write('  Alice goi y so dau tien: '), write(Guess), nl,
    process_guess(Guess),
    play_game_smart_ai.
play_game_smart_ai :-
    guesses(N),
    max_guesses(Max),
    N =:= Max,
    write('  *********************************'), nl,
    write('  Ban da het luot doan. So cua Bob la: '),
    answer(Answer),
    write(Answer), nl,
    write('  Chuc ban may man lan sau!'), nl,
    write('*********************************'), nl,
    restart_game.

% Khởi động trò chơi với AI thông minh
start_game_smart_ai :-
    retractall(answer(_)),
    retractall(guesses(_)),
    assertz(guesses(0)),
    random(1, 100, X),
    assertz(answer(X)),
    write('*********************************'), nl,
    write('  Tro choi doan so bat dau!'), nl,
    write('  Bob da chon mot so tu 1 den 100.'), nl,
    write('  Ban hay doan so do.'), nl,
    write('*********************************'), nl,
    play_game_smart_ai.

% Khởi động lại trò chơi với AI thông minh
restart_game :-
    write('  *********************************'), nl,
    write('  Ban co muon choi lai khong? (co/khong): '),
    read(Choice),
    (Choice = 'co' -> nl, start_game_smart_ai ; write('  Cam on ban da tham gia tro choi!'), nl,
    write('*********************************'), nl, halt).

% Chạy trò chơi với AI thông minh
:- start_game_smart_ai.
