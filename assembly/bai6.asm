.MODEL SMALL ;KHAI BAO CHE DO BO NHO CUA CHUONG TRINH
.STACK 100H  ;KHAI BAO NGAN XEP
.DATA        ;KHAI BAO DU LIEU
    THONGBAO1 DB 'NHAP KY TU: $'
.CODE        ;KHAI BAO CAC LENH XU LY
    MAIN PROC ;BAT DAU HAM MAIN
        ;KHOI TAO THANH GHI DS
        MOV AX,@DATA
        MOV DS,AX
        
        ;HIEN THI THONGBAO1
        MOV AH,09H
        LEA DX,THONGBAO1
        INT 21H
        
        MOV CX,10 ;KHOI TAO SO VONG LAP
        
        ;NHAP KY TU
        MOV AH,01H
        LAP:
            INT 21H
            CMP CX,0 ;KIEM TRA DU SO VONG LAP
            JE THOAT ;NEU BANG THI NHAY DEN NHAN THOAT
            LOOP LAP ;NEU KHONG BANG THI NHAY DEN NHAN LAP
        THOAT:
            ;THOAT CHUONG TRINH, TRO VE DOS
            MOV AH,4CH
            INT 21H        
    MAIN ENDP ;KET THUC HAM MAIN
END MAIN      ;KET THUC CHUONG TRINH