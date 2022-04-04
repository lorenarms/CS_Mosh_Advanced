using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

public class Guild
{
    private readonly List<string> _members = new List<string>();

    public event Action<string> NewMemberAdded;

    public event Action<string> NewMemberRemoved;

    public void AddMember(string memberName)
    {
        _members.Add(memberName);

        NewMemberAdded?.Invoke(memberName);

    }

    public void RemoveMember(string memberName)
    {
        if (_members.Contains(memberName))
        {
            _members.Remove(memberName);
            NewMemberRemoved?.Invoke(memberName);

        }
        else
        {
            WriteLine($"{memberName} is not in this guild");
        }
        

    }
}

public class MemberWelcomer
{
    public void WelcomeMember(string memberName)
    {
        WriteLine($"Welcome {memberName}");
    }

    public void RemoveMember(string memberName)
    {
        
        
        WriteLine($"{memberName} has left the guild");
    }
}

public class GuildHall
{
    public void AddRoom(string memberName)
    {
        WriteLine($"A room has been added for {memberName}");
    }

    public void RemoveRoom(string memberName)
    {
        WriteLine($"The room for {memberName} has been removed from the hall");
    }
}
