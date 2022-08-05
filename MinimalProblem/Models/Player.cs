namespace MinimalProblem.Models
{
    public class PlayerState
    {
        public event EventHandler? NameChanged;

        public string Name { get; set; }

        public void SetPlayerName(string name)
        {
            this.Name = name;
            this.NotifyNameChanged();
        }

        public void NotifyNameChanged()
        => this.NameChanged?.Invoke(this, EventArgs.Empty);
    }
}
