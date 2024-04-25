namespace EFK.DotnetPerformanceWorkshop.Part2.Console;

using AutoMapper;
using EFK.DotnetPerformanceWorkshop.Part2.Console.JsonModels;
using Newtonsoft.Json;

public class ExampleEasyOriginal
{
    public static string[] ExampleInput = ["Sol Ring", "Counterspell", "Lightning Bolt", "Swords to Plowshares", "Cyclonic Rift", "Rhystic Study", "Arcane Signet", "Cultivate"];

    private static readonly IMapper Mapper = new MapperConfiguration(x => x.CreateMap<CardModel, DataDto>())
        .CreateMapper();

    public static IEnumerable<DataDto> TopData(IEnumerable<string>? input)
    {
        if (input == null)
        {
            return Array.Empty<DataDto>();
        }

        var rawJsonString = File.ReadAllText("oracle-cards-20240425090207.json");
        var parsedModels = JsonConvert.DeserializeObject<IEnumerable<CardModel>>(rawJsonString);
        var dataEntries = Mapper.Map<IEnumerable<CardModel>, IEnumerable<DataDto>>(parsedModels);

        var result = new List<DataDto>();

        foreach (var entry in dataEntries)
        {
            foreach (var name in input)
            {
                if (entry.Name == name)
                {
                    result.Add(entry);
                }
            }
        }

        return result;
    }
}
