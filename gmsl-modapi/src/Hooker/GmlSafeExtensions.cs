using Underanalyzer.Compiler;
using UndertaleModLib;
using UndertaleModLib.Compiler;
using UndertaleModLib.Models;

namespace GMSL.Hooker;

public static class GmlSafeExtensions {
    public static void ReplaceGmlSafe(this UndertaleCode code, string gmlCode, UndertaleData data)
    {
        // CompileResult result = new();
        
        var group = new CompileGroup(data);
        group.QueueCodeReplace(code, gmlCode);
        group.Compile();
        
        // try { code.ReplaceGML(gmlCode, data); }
        // // UndertaleModLib is trying to write profile cache but fails, we don't care
        // catch(Exception ex) {
        //     if(ex.Message.StartsWith("Error during writing of GML code to profile", StringComparison.InvariantCulture))
        //         return;
        //     throw;
        // }
    }

    // public static void AppendGmlSafe(this UndertaleCode code, string gmlCode, UndertaleData data) {
    //     try { code.AppendGML(gmlCode, data); }
    //     // UndertaleModLib is trying to write profile cache but fails, we don't care
    //     catch(Exception ex) {
    //         if(ex.Message.StartsWith("Error during writing of GML code to profile", StringComparison.InvariantCulture))
    //             return;
    //         throw;
    //     }
    // }
}
