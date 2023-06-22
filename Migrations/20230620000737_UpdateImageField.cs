using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunGroup.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImageField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("UPDATE Race SET Image = 'https://www.bing.com/ck/a?!&&p=5d2e375fc78cdfc7JmltdHM9MTY4NzEzMjgwMCZpZ3VpZD0xNjQ1ZDA4ZC1hZmMxLTZlZDctMDI2MC1jMmUwYWVhZTZmNDEmaW5zaWQ9NTY2Nw&ptn=3&hsh=3&fclid=1645d08d-afc1-6ed7-0260-c2e0aeae6f41&u=a1L2ltYWdlcy9zZWFyY2g_cT1ydW5uaW5nIGltYWdlcyZGT1JNPUlRRlJCQSZpZD01NUQ3RjJCMUZCRTg0QTYwMTBFQzJCRkFGRDg0NzNGNjY0REFDMTUx&ntb=1' WHERE Image = ''");
            //migrationBuilder.Sql("UPDATE Club SET Image = 'https://www.bing.com/ck/a?!&&p=5d2e375fc78cdfc7JmltdHM9MTY4NzEzMjgwMCZpZ3VpZD0xNjQ1ZDA4ZC1hZmMxLTZlZDctMDI2MC1jMmUwYWVhZTZmNDEmaW5zaWQ9NTY2Nw&ptn=3&hsh=3&fclid=1645d08d-afc1-6ed7-0260-c2e0aeae6f41&u=a1L2ltYWdlcy9zZWFyY2g_cT1ydW5uaW5nIGltYWdlcyZGT1JNPUlRRlJCQSZpZD01NUQ3RjJCMUZCRTg0QTYwMTBFQzJCRkFGRDg0NzNGNjY0REFDMTUx&ntb=1' WHERE Image = ''");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
