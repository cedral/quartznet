using System;

// ReSharper disable once CheckNamespace
namespace Quartz
{
    public static class TestConstants
    {
        static TestConstants()
        {
            SqlServerUser = Environment.GetEnvironmentVariable("MSSQL_USER") ?? "sa";
            SqlServerPassword = Environment.GetEnvironmentVariable("MSSQL_PASSWORD") ?? "Quartz!DockerP4ss";
            // we cannot use trusted connection as it's not available for Linux provider
            SqlServerConnectionString = $"Server=localhost;Database=quartznet;Integrated Security=true;";
            SqlServerConnectionStringMOT = $"Server=localhost;Database=quartznetMOT;Integrated Security=true;";
        }

        public static string SqlServerUser { get; }
        public static string SqlServerPassword { get; }

        public static string SqlServerConnectionString { get; }
        public static string SqlServerConnectionStringMOT { get; }

        public const string DefaultSerializerType = "json";

        public const string DefaultSqlServerProvider = "SqlServer";
    }
}