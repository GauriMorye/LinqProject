namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Songs> songs = new List<Songs>
            {
                new Songs(111,"Kaise Mujhe","Shreya Ghoshal",3.5),
                new Songs(112, "Ye Ishq Haye", "Shreya Ghoshal", 4.2),
                new Songs(113, "Jeena Jeena", "Atif Aslam", 2.3),
                new Songs(114, "Saawali Si Raat", "Arjit Singh", 4.1),
                new Songs(114, "Naina", "Arijit Singh", 4.1),
            };
            List<Album> albums = new List<Album>
            {
                new Album("Album1","Arijit Singh","Hindi"),
                new Album("Album2","Shreya Ghoshal","Hindi"),
                new Album("Album3","Atif Aslam","Hindi")
            };

            Console.WriteLine("List of Songs: ");
            var list = songs.Join(albums, songs => songs.Artist, albums => albums.Artist,
                (songs, album) => new {
                    Name = songs.SongName,
                    Artist = songs.Artist,
                    Album= album.AlbumName,
                }
                ) ;
            Console.WriteLine("Name\t\t Artist \t\t Album");
            Console.WriteLine();
            
            int i = 0;
            foreach(var a in list)
            {
                Console.WriteLine("______________________________________________________");
                Console.WriteLine($"{i++}.{a.Name} \t {a.Artist}\t\t{a.Album}");   
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select the Artist:\na.Arijit Singh\nb.Shreya Ghoshal\nc.Atif Aslam");
            Console.WriteLine("______________________________________");
            var option=Console.ReadLine();
            switch (option)
            {
                case "a":
                    Console.WriteLine("Artist=Arijit Singh");
                    Console.WriteLine("______________________________________"); 
                    var artistlist1 = songs.Where(x => x.Artist == "Arijit Singh");
                    foreach(var song in artistlist1)
                    {
                        Console.WriteLine($"Song Name={song.SongName}   Duration={song.duration}");
                    }
                    break;
                case "b":
                    Console.WriteLine("Artist=Shreya Ghoshal");
                    Console.WriteLine("______________________________________");
                    var artistlist2 = songs.Where(x => x.Artist == "Shreya Ghoshal");
                    foreach (var song in artistlist2)
                    {
                        Console.WriteLine($"Song Name={song.SongName}   Duration={song.duration}");
                    }
                    break;
                case "c":
                    Console.WriteLine("Artist=Atif Aslam");
                    Console.WriteLine("______________________________________");
                    var artistlist3 = songs.Where(x => x.Artist == "Atif Aslam");
                    foreach (var song in artistlist3)
                    {
                        Console.WriteLine($"Song Name={song.SongName}   Duration={song.duration}");
                    }
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;
            }
        }
    }
}