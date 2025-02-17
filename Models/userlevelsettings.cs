namespace ASPNETMaker2024.Models;

// Partial class
public partial class chatbot {
    // Configuration
    public static partial class Config
    {
        //
        // ASP.NET Maker 2024 user level settings
        //

        // User level info
        public static List<UserLevel> UserLevels = [
            new() { Id = -2, Name = "Anonymous" }
        ];

        // User level priv info
        public static List<UserLevelPermission> UserLevelPermissions = [
            new() { Table = "{F74BDC2E-8C3F-45C8-A887-A125D888F9A0}Question", Id = -2, Permission = 0 },
            new() { Table = "{F74BDC2E-8C3F-45C8-A887-A125D888F9A0}Chatting", Id = -2, Permission = 72 }
        ];

        // User level table info // DN
        public static List<UserLevelTablePermission> UserLevelTablePermissions = [
            new() { TableName = "Question", TableVar = "Question", Caption = "Question", Allowed = true, ProjectId = "{F74BDC2E-8C3F-45C8-A887-A125D888F9A0}", Url = "QuestionList" },
            new() { TableName = "Chatting", TableVar = "Chatting", Caption = "Chatting", Allowed = true, ProjectId = "{F74BDC2E-8C3F-45C8-A887-A125D888F9A0}", Url = "Chatting" }
        ];
    }
} // End Partial class
