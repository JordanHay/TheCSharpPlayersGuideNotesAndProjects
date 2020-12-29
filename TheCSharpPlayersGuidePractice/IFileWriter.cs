using System;
namespace TheCSharpPlayersGuidePractice
{
    public interface IFileWriter
    {

        string Extension { get; }
        void Write(string filename);
    }
}
