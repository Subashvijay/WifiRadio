// See https://aka.ms/new-console-template for more information
using NAudio.Wave;

Console.WriteLine("Hello, World!");
var audioFileS = @"D:\Music\Aadi-Pona-Aavani.mp3";
using (var audioFile = new AudioFileReader(audioFileS))
using (var outputDevice = new WaveOutEvent())
{
    outputDevice.Init(audioFile);
    outputDevice.Play();
    while (outputDevice.PlaybackState == PlaybackState.Playing)
    {
        Thread.Sleep(1000);
    }
}