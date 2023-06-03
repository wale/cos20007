namespace CaseStudy1;

public class IdentifiableObject 
{
    private List<string> _identifiers;

    public IdentifiableObject(string[] idents)
    {
        _identifiers = new List<string>();

        foreach (string id in idents) {
            AddIdentifier(id);
        }
    }

    public bool AreYou(string id) 
    {
        foreach (string idx in _identifiers) 
        {
            if (id.ToLower() == idx) 
            {
                return true;
            }
        }
        return false;
    }

    public string FirstId
    {
        get {
            if (_identifiers.Count == 0) 
            {
                return "";
            } else
            {
                return _identifiers.First();
            }
        }
    }

    public void AddIdentifier(string id)
    {
        _identifiers.Add(id.ToLower());
    }
}