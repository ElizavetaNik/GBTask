﻿using static System.Console;
Write ("Введите число a:");
int a = int.Parse(ReadLine());
Write ("Введите число b:");
int b = int.Parse(ReadLine());
Write ("Введите число c:");
int c = int.Parse(ReadLine());

int max = a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

Write ("max=");
WriteLine(max);

