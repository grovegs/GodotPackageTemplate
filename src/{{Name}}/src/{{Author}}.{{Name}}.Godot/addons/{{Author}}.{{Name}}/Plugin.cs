#if TOOLS
using Godot;

namespace {{Author}}.{{Name}};

[Tool]
public partial class Plugin : EditorPlugin
{
    public override void _EnterTree()
    {
        // AddAutoloadSingleton
    }

    public override void _ExitTree()
    {
        // RemoveAutoloadSingleton
    }
}
#endif