// See https://aka.ms/new-console-template for more information
 Console.WriteLine ("*****Atama ve İşlemli Atama*****") ;
 // Atama ve İşlemli Atama
int x = 3 ;
int y = 3 ;
y = y+2 ;
Console.WriteLine(y) ;
y += 2 ;
Console.WriteLine(y) ;
y /=1 ;
Console.WriteLine(y) ;
x *=2 ;
Console.WriteLine(x) ;


Console.WriteLine ("*****Mantıksal Operatörler*****") ;
// Mantıksal Operatörler
// ||, &&, !
bool isSuccess = true ;
bool isCompleted = false ;


if (isSuccess || isCompleted)
  Console.WriteLine("Great!") ;

if (isSuccess && !isCompleted)
  Console.WriteLine ("Fine!") ;



Console.WriteLine ("*****İlişkisel Operatörler*****") ;
// İlişkisel Operatörler
// <, >, <=, >=, ==, !=
int a = 3;
int b = 4 ;
bool result = a < b ;
  Console.WriteLine (result) ;
result = a > b ;
  Console.WriteLine (result) ;
result = a >= b ;
  Console.WriteLine (result) ;
result = a <= b ;
  Console.WriteLine (result) ;
result = a == b ;
Console.WriteLine (result) ;
result = a != b  ;
Console.WriteLine (result) ;

Console.WriteLine ("*****Aritmetik Operatörler*****") ;
// Aritmetik Operatörler
// /, *, +, -
int sayı1 = 10 ;
int sayı2 = 5 ;
int sonuc1 = sayı1 / sayı2 ;
Console.WriteLine (sonuc1) ;
sonuc1 = sayı1 + sayı2 ;
Console.WriteLine (sonuc1) ;
sonuc1 = sayı1 * sayı2 ;
Console.WriteLine (sonuc1) ;









