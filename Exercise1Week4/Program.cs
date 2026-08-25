using Exercise1Week4;

FooBar generator = new FooBar();

generator.AddRule(3, "foo");
generator.AddRule(4, "baz");
generator.AddRule(5, "bar");
generator.AddRule(7, "jazz");
generator.AddRule(9, "huzz");

Console.WriteLine(generator.GenerateSequence(1, 20));