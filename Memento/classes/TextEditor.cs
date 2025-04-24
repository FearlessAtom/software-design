namespace Memento;

public class TextEditor
{
    private TextDocument TextDocument;
    private Stack<TextDocument.TextDocumentMemento> History = new Stack<TextDocument.TextDocumentMemento>();

    public TextEditor()
    {
        this.TextDocument = new TextDocument();
    }

    public string GetContent()
    {
        return this.TextDocument.GetText();
    }

    public void Undo()
    {
        if (this.History.Count > 0)
        {
            this.TextDocument.Restore(this.History.Pop());
        }
    }

    public void Backup()
    {
        this.History.Push(TextDocument.Save());
    }

    public void Write(string text)
    {
        this.Backup();
        this.TextDocument.AppendText(text);
    }
}
