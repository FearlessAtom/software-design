namespace Memento;

public class TextDocument
{
    private string Text = string.Empty;

    public void AppendText(string Text)
    {
        this.Text = this.Text + Text;
    }

    public string GetText()
    {
        return Text;
    }

    public void Restore(TextDocumentMemento memento)
    {
        this.Text = memento.GetState();
    }

    public void SetText(string Text)
    {
        this.Text = Text;
    }

    public TextDocumentMemento Save()
    {
        return new TextDocumentMemento(Text);
    }

    public class TextDocumentMemento
    {
        private string Text;

        internal TextDocumentMemento(string Text)
        {
            this.Text = Text;
        }

        internal string GetState()
        {
            return this.Text;
        }
    }
}
