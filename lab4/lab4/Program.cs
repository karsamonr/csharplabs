using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            MP3Player iPod = new MP3Player("8 GB");
            iPod.Play();
            iPod.Pause();
        }
    }

    public interface IMusicPlayer
    {
        void Play();
        void Pause();
    }

    public class MusicDevice
    {
        public string StorageCapacity { get; }

        public MusicDevice(string storageCapacity)
        {
            StorageCapacity = storageCapacity;
        }
    }

    public class MP3Player : MusicDevice, IMusicPlayer
    {
        public bool IsPlaying { get; set; } = false;
        public MP3Player(string storageCapacity) : base(storageCapacity) { }
        public void Play()
        {
            if(!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("Now playing ACDC - Back In Black!");
            } else
            {
                Console.WriteLine("Music is already playing");
            }
            
        }
        public void Pause()
        {
            if (IsPlaying)
            {
                IsPlaying = false;
                Console.WriteLine("Music has paused");
            }
            else
            {
                Console.WriteLine("Music is already paused");
            }
        }
    }
}
