namespace Adapter;

public class FileWriter
{
    public StreamWriter Writer;

    public FileWriter(string FilePath, bool Append=false)
    {
        this.Writer = new StreamWriter(FilePath, Append);
    }

    public FileWriter(StreamWriter Writer)
    {
        this.Writer = Writer;
    }

    ~FileWriter()
    {
        this.Writer.Dispose();
        this.Writer.Close();
    }

    public void Write(string Content)
    {
        this.Writer.Write(Content);
        this.Writer.Flush();
    }

    public void WriteLine(string Content)
    {
        this.Writer.WriteLine(Content);
        this.Writer.Flush();
    }
}   
