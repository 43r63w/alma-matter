using Almamatter.Domain.Entities;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;

namespace Almamatter.Infrastructure.Data.SeedData;

public static class DbInitializer
{
    public static async Task SeedAsync(DbContext context, CancellationToken cancellationToken = default)
    {

        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "registry.xlsx");
        if (!File.Exists(filePath))
        {
            return;
        }

        using var workbook = new XLWorkbook(filePath);
        var worksheet = workbook.Worksheet(1);
        var rows = worksheet.RowsUsed();
        var dataRows = rows.Skip(1);

        var headerMap = new Dictionary<string, int>();
        foreach (var cell in rows.First().Cells())
        {
            headerMap[cell.GetValue<string>().Trim()] = cell.Address.ColumnNumber;
        }

        string GetVal(IXLRow row, string colName) =>
            headerMap.TryGetValue(colName, out int idx) ? row.Cell(idx).GetValue<string>() : "";

        var universities = new List<University>();

        foreach (var row in dataRows)
        {
            var type = GetVal(row, "institution_type_name");


            var validTypes = new[] { "Університет", "Академія", "Інститут" };
            if (!validTypes.Any(t => type.Contains(t, StringComparison.OrdinalIgnoreCase)))
                continue;

            universities.Add(new University
            {
                Name = GetVal(row, "full_name"),
                City = GetVal(row, "koatuu_city"),
                Address = GetVal(row, "address"),
                WebsiteUrl = GetVal(row, "website"),
            });
        }


    }
}