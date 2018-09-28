# RandomStringExtension
Useful Extension for System.Random to generate random string

Introduce :    
D / a : Digital (0-9)   
C / c : Upper case / Lower case char (A-z)   
S / s : Symbol (!@#$%^&*)   
A / a : Any char and digital ( Upper / Lower )   
 '*'   : Any char and digital   
 '!'   : And char, digital and symbol
 other : other char like -
  
Example : 

`rnd.NextString("CC-AAAA")`//[two char]-[four char/digit]   
Result : AD-57B2

`rnd.NextString("DDDD-DDDD")`//[four digit]-[four digit]   
Result : 2846-3251

`rnd.NextString("aaaaaaaa")`//[eight lower char/digit]   
Result : dkgyleba

`rnd.NextString("********")`//[eight char/digit]   
Result : 2skEd3B

`rnd.NextString("!!!!!!!!")`//[eight char/digit/symbol]   
Result : 2$#kEd3b

`rnd.NextString("SSSSSSSS", "+=-")`//[eight assigned symbol]   
Result : +=--+++=