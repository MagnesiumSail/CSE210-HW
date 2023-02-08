Console.WriteLine("Hello World");

//john.Display();
Team firebirds = new Team("Firebirds");

Player john = new Player("John Henderson", 12);
Player tim = new Player("Tim Nunn", 13);

firebirds.addPlayer(john);
firebirds.addPlayer(tim);
firebirds.displayRoster();
Team mongooses = new Team("mongooses");
Player rick = new Player("Rick Geuss", 7);
Player tom = new Player("Tom Runn", 16);
mongooses.addPlayer(rick);
mongooses.addPlayer(tom);
mongooses.displayRoster();

Match match1 = new Match(firebirds, mongooses);

