byte someByte = 255;
Byte some = 255;

Console.WriteLine(someByte + some);


//8 bit = 1 byte

byte a = 0;
Byte b = 255;

sbyte c = -128;
SByte d = 127;

ushort e = 0;
UInt16 f = 65535;

short g = -32768;
Int16 h = 32767;

uint i = 0u;
UInt32 j = 4294967295;

int k = -2147483648;
Int32 l = 2147483647;

ulong r = 0ul;
UInt64 s = 18446744073709551615UL;

long t = -9223372036854775808;
Int64 u = 9223372036854775807;

//--------------------------------------------

float v = -0.1f;
Single x = 545.96f;

double y = -0.05123456789123456789123456789d;
Double z = 5446416.8564648564d;

decimal aa = 45454.15415454456454554154554123456789123456789123456789m;
Decimal bb = -54564856464.8494949494M;

Console.WriteLine("This is float {0},  {1}", v, bb);
Console.WriteLine($"This is double {y}");
Console.WriteLine("This is decimal {0}", aa);

//-------------------------------------------------

bool cc = false;
Boolean dd = true;

//---------------------------------------------

char ee = 'ա';
Char ff = 'A';

//----------------------------------------------

string firstName = "Poghos";
String LastName = "Poghosyan";

char jj = 'c';
char hh = '\x0041'; // 16-ական համակարգ
char mm = '\u0041'; // Unicode
Console.WriteLine(hh);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(mm);
Console.BackgroundColor = ConsoleColor.Magenta;
Console.ResetColor();
Console.WriteLine();
