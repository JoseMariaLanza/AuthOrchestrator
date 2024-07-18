namespace AuthOrchestrator.Auth.Constants
{
    public static class UserTypes
    {
        public static class Admin
        {
            public const int Id = 1;
            public const string HierarchyNode = "/1/";
        }

        public static class Staff
        {
            public const int Id = 2;
            public const string HierarchyNode = "/2/";

            public static class Management
            {
                public const int Id = 3;
                public const string HierarchyNode = "/2/1/";

                public static class SiteAdmin
                {
                    public const int Id = 4;
                    public const string HierarchyNode = "/2/1/1/";
                }

                public static class Director
                {
                    public const int Id = 5;
                    public const string HierarchyNode = "/2/1/2/";
                }

                public static class Manager
                {
                    public const int Id = 6;
                    public const string HierarchyNode = "/2/1/3/";
                }

                public static class OperationsManager
                {
                    public const int Id = 7;
                    public const string HierarchyNode = "/2/1/4/";
                }

                public static class AdministrativeAssistant
                {
                    public const int Id = 8;
                    public const string HierarchyNode = "/2/1/5/";
                }
            }

            public static class HR
            {
                public const int Id = 9;
                public const string HierarchyNode = "/2/2/";
            }

            public static class ITSupport
            {
                public const int Id = 10;
                public const string HierarchyNode = "/2/3/";
            }

            public static class Finance
            {
                public const int Id = 11;
                public const string HierarchyNode = "/2/4/";
            }
        }

        public static class Architect
        {
            public const int Id = 12;
            public const string HierarchyNode = "/3/";
        }

        public static class SecuritySpecialist
        {
            public const int Id = 13;
            public const string HierarchyNode = "/4/";
        }

        public static class NetworkEngineer
        {
            public const int Id = 14;
            public const string HierarchyNode = "/5/";
        }

        public static class SupportEngineer
        {
            public const int Id = 15;
            public const string HierarchyNode = "/6/";
        }

        public static class ITAdministrator
        {
            public const int Id = 16;
            public const string HierarchyNode = "/7/";
        }

        public static class SME
        {
            public const int Id = 17;
            public const string HierarchyNode = "/8/";
        }

        public static class TeamMember
        {
            public const int Id = 18;
            public const string HierarchyNode = "/9/";

            public static class ProjectManager
            {
                public const int Id = 19;
                public const string HierarchyNode = "/9/1/";
            }

            public static class TeamLead
            {
                public const int Id = 20;
                public const string HierarchyNode = "/9/2/";
            }

            public static class Developer
            {
                public const int Id = 21;
                public const string HierarchyNode = "/9/3/";

                public static class FrontendDeveloper
                {
                    public const int Id = 22;
                    public const string HierarchyNode = "/9/3/1/";
                }

                public static class BackendDeveloper
                {
                    public const int Id = 23;
                    public const string HierarchyNode = "/9/3/2/";
                }

                public static class QAEngineer
                {
                    public const int Id = 24;
                    public const string HierarchyNode = "/9/3/3/";
                }

                public static class UXDesigner
                {
                    public const int Id = 25;
                    public const string HierarchyNode = "/9/3/4/";
                }

                public static class ProductOwner
                {
                    public const int Id = 26;
                    public const string HierarchyNode = "/9/3/5/";
                }
            }

            public static class DevOpsEngineer
            {
                public const int Id = 27;
                public const string HierarchyNode = "/9/4/";
            }

            public static class DataScientist
            {
                public const int Id = 28;
                public const string HierarchyNode = "/9/5/";
            }
        }
    }
}
