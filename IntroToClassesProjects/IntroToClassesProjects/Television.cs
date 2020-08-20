using System;
namespace IntroToClassesProjects
{
    public class Television
    {
        private int currentChannel = 0;
        private int currentVolume = 0;
        // increases the volume by one
        public void increaseVolume()
        {
            currentVolume++;
            Console.WriteLine("Volume has been raised to " + currentVolume);
        }
        // decreases the volume by one
        public void decreaseVolume()
        {
            currentVolume--;
            Console.WriteLine("Volume has been decreased to " + currentVolume);
        }
        // // returns the current volume
        public int volume()
        {
            return currentVolume;
        }
        // increases the channel num by one
        public void increaseChannel()
        {
            currentChannel++;
            Console.WriteLine("The channel has been changed to " + currentChannel);
        }
        // decreases the channel num by one
        public void decreaseChannel()
        {
            currentChannel--;
            Console.WriteLine("The channel has been changed to " + currentChannel);
        }
        // returns the current channel
        public int channel()
        {
            return currentChannel;
        }
    
    }
}
