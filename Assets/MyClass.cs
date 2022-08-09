public class MyClass
{
    private string name;

    public MyClass() {
        name = string.Empty;
    }
    public MyClass(string name) {
        this.name = name;
    }

    public void SetName(string name) { this.name = name; }
    public string GetName() { return name; }
}
