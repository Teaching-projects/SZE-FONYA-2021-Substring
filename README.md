Az automata kirajzoltatásának menete:

1.) A program.cs fájl futtatása: ez megnyit egy parancssori ablakot, melybe a felhasználónak be kell gépelnie az általa választott szót. Ekkor létrejön egy myFile.dot nevű fájl az .exe fájlt tartalmazó mappában. <br>
2.) Egy parancssori ablakot nyitva a következő kódot kell a fájlt tartalmazó mappa elérési útján futtatni:
    dot -Tsvg myFile.dot > output.svg <br>
3.) Ez létrehoz ugyanezen a mappán belül egy output.svg nevű fájlt, amely az eredményt tartalmazza és amely pl.: Google Chrome böngészőben megtekinthető.