﻿int a = 4;
int b = 8;
int c = 3;
int d = 5;
int e = 4;

int max = a;


if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("max = ");
Console.WriteLine (max);