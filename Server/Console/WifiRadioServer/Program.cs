// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using NAudio.Wave;

Console.WriteLine("Hello, World!");
var audioFileS = @"D:\Music\Aadi-Pona-Aavani.mp3";
using (var audioFile = new AudioFileReader(audioFileS))
using (var outputDevice = new WaveOutEvent())
{
    outputDevice.Init(audioFile);
    outputDevice.Play();
    Stopwatch st = new();
    while (outputDevice.PlaybackState == PlaybackState.Playing)
    {
        Console.Clear();
        Console.WriteLine(st.ElapsedMilliseconds / 1000);
        Thread.Sleep(1000);
    }
}