// See https://aka.ms/new-console-template for more information
using System;
using adapter;

Console.WriteLine("Hello, World!");
LocalUser localUser = new("Romeo","1",new DateTime(2029,12,31));
SvUser svUser = new("Romeo","1",new DateTime(2029,12,31));
SvToLocalAdapter svToLocalAdapter = new(svUser);
Minecraft minecraft = new();
minecraft.AddUser(svToLocalAdapter);

minecraft.GetUsers();