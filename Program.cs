// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//string testCharacter;

// testCharacter = Blocks.BlockCharacters.DecimalToUnicode[10];
// Console.WriteLine(testCharacter);

// Blocks.VirtualScreen VS = new Blocks.VirtualScreen(10,10);

// VS.Poke(6,6,Blocks.Pixel.Set);
// VS.Poke(7,7,Blocks.Pixel.Set);
// testCharacter = VS.MapPixelsToConsoleCharacter(3,3);
// Console.WriteLine(testCharacter);

// VS.Poke(6,6,Blocks.Pixel.Unset);
// VS.Poke(6,7,Blocks.Pixel.Set);
// VS.Poke(7,6,Blocks.Pixel.Set);
// testCharacter = VS.MapPixelsToConsoleCharacter(3,3);
// Console.WriteLine(testCharacter);

Blocks.PixelScreenMapper VS = new Blocks.PixelScreenMapper(10,10);

VS.Poke(6,6,Blocks.Pixel.Set);
VS.Poke(7,7,Blocks.Pixel.Set);
VS.PrintCharacterAt(3,3);

Console.WriteLine("ending");
