function caesarCipher(plaintext, key) {
  var ciphertext = "";
  var keyIndex = 0;

  for (var i = 0; i < plaintext.length; i++) {
    var char = plaintext[i];
    var charCode = char.charCodeAt(0);

    if (char >= "A" && char <= "Z") {
      var keyChar = key[keyIndex % key.length];
      var keyCharCode = keyChar.charCodeAt(0);
      var shift = keyCharCode - "A".charCodeAt(0);

      var encryptedCharCode =
        ((charCode - "A".charCodeAt(0) + shift) % 26) + "A".charCodeAt(0);
      var encryptedChar = String.fromCharCode(encryptedCharCode);

      ciphertext += encryptedChar;
      keyIndex++;
    } else if (char >= "a" && char <= "z") {
      var keyChar = key[keyIndex % key.length];
      var keyCharCode = keyChar.charCodeAt(0);
      var shift = keyCharCode - "a".charCodeAt(0);

      var encryptedCharCode =
        ((charCode - "a".charCodeAt(0) + shift) % 26) + "a".charCodeAt(0);
      var encryptedChar = String.fromCharCode(encryptedCharCode);

      ciphertext += encryptedChar;
      keyIndex++;
    } else {
      ciphertext += char;
    }
  }

  return ciphertext;
}

var plaintext =
  "Hello there, My name is Duy. Nice to meet you! I will hack your computer. Haha =)";
var key = "Can you hack it?";

var encryptedText = caesarCipher(plaintext, key);
console.log(encryptedText);

// run with NODE.JS => node encrypt.js
