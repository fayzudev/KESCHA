﻿using KESCHA.Classes;
Animal kescha=new Bird(name:"Kescha", UserAge:26, AnimalAge:10);
Animal kasee = new Pet(name:"Kasee", UserAge: 26, AnimalAge:2);
//converting
System.Console.Write("Enter your name: ");
string UserName = Console.ReadLine();
System.Console.Write("Enter your age: ");
int UserAge=int.Parse(Console.ReadLine());
System.Console.Write("Enter animal age: ");
int AnimalAge=int.Parse(Console.ReadLine());
// kescha.greeting(UserName,UserAge,AnimalAge);
// kasee.greeting(UserName,UserAge,AnimalAge);

kescha.greeting2(UserName);
kasee.greeting2(UserName);
System.Console.WriteLine("Tell me about your friends!");

kescha.AboutmyFriends(friendsName: UserName);
System.Console.WriteLine("------");
kescha.usingifelse();
System.Console.WriteLine("------");
kescha.usingstringmessage();
System.Console.WriteLine("------");
kescha.usingswitch(UserAge);
System.Console.WriteLine("------");
kescha.usingresultswitch(UserAge);