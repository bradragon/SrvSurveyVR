﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using SrvSurvey.game;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SrvSurvey.net.Spansh;
using static SrvSurvey.widgets.GameColors;

namespace SrvSurvey.net
{
    partial class Spansh
    {
        public async Task<Guid> createGalaxyRoute(GalaxyRouteRequest req)
        {
            Game.log($"Spansh.createGalaxyRoute: {req.source} => {req.destination}");

            try
            {
                // TODO: this needs to culture agnostic for serializing decimal numbers
                var props = JObject.FromObject(req)
                    .Properties()
                    .Select(p => $"{p.Name}={p.Value}");
                var formTxt = string.Join("&", props);

                var body = new StringContent(formTxt, Encoding.ASCII, "application/x-www-form-urlencoded");
                var response = await Spansh.client.PostAsync($"https://spansh.co.uk/api/generic/route", body);

                var responseText = await response.Content.ReadAsStringAsync();
                if (responseText == "{\"error\":\"Invalid request\"}")
                {
                    Debugger.Break();
                    throw new Exception("Bad Spansh request: " + responseText);
                }

                var obj = JsonConvert.DeserializeObject<JObject>(responseText)!;
                if (Guid.TryParse(obj["job"]?.Value<string>(), out Guid jobId))
                    return jobId;
                else
                    return Guid.Empty;
            }
            catch (Exception ex)
            {
                Util.isFirewallProblem(ex);
                return Guid.Empty;
            }
        }

        public class GalaxyRouteRequest
        {
            public string source;
            public string destination;
            public int is_supercharged; // bool ?
            public int use_supercharge; // bool ?
            public int use_injections; // bool ?
            public int exclude_secondary; // bool ?
            public int refuel_every_scoopable; // bool ?
            public double fuel_power;
            public double fuel_multiplier;
            public double optimal_mass;
            public double base_mass;
            public double tank_size;
            public double internal_tank_size;
            public double reserve_size;
            public double max_fuel_per_jump;
            public string range_boost;
            public string ship_build;
            public int max_time;
            public int cargo;
            public Algorithm algorithm;

            [JsonConverter(typeof(StringEnumConverter))]
            public enum Algorithm
            {
                fuel,
                fuel_jumps,
                guided,
                optimistic,
                pessimistic,
            }

            public static GalaxyRouteRequest ColonyHopper => new()
            {
                source = "",
                destination = "",
                is_supercharged = 0,
                use_supercharge = 0,
                use_injections = 0,
                exclude_secondary = 0,
                refuel_every_scoopable = 1,
                fuel_power = 2.6,
                fuel_multiplier = 0.008,
                optimal_mass = 1794,
                base_mass = 1533.13,
                tank_size = 648,
                internal_tank_size = 1.13,
                reserve_size = 0,
                max_fuel_per_jump = 5.3,
                range_boost = "",
                ship_build = "[{\"header\":{\"appName\":\"EDSY\",\"appVersion\":419049901,\"appURL\":\"https://edsy.org/#/L=Iz00000H4C0S00,,,9p300ADw00ARM00AfkG05GS80Au600BCQ00BS200Bcg00,,Bfo00Bfo00Bfo00BeE00BeE00Bcg00Bcg00Bb600Bb600BZY004wE00\"},\"data\":{\"event\":\"Loadout\",\"Ship\":\"federation_corvette\",\"ShipName\":\"\",\"ShipIdent\":\"\",\"HullValue\":183147460,\"ModulesValue\":62412940,\"UnladenMass\":1532,\"CargoCapacity\":0,\"MaxJumpRange\":14.194997,\"FuelCapacity\":{\"Main\":648,\"Reserve\":1.13},\"Rebuy\":12278020,\"Modules\":[{\"Slot\":\"CargoHatch\",\"Item\":\"modularcargobaydoor\",\"On\":true,\"Priority\":0},{\"Slot\":\"Armour\",\"Item\":\"federation_corvette_armour_grade1\",\"On\":true,\"Priority\":0,\"Value\":0},{\"Slot\":\"PowerPlant\",\"Item\":\"int_powerplant_size8_class1\",\"On\":true,\"Priority\":0,\"Value\":1441230},{\"Slot\":\"MainEngines\",\"Item\":\"int_engine_size7_class5\",\"On\":true,\"Priority\":0,\"Value\":51289110},{\"Slot\":\"FrameShiftDrive\",\"Item\":\"int_hyperdrive_size6_class3\",\"On\":true,\"Priority\":0,\"Value\":1797730,\"Engineering\":{\"BlueprintName\":\"FSD_LongRange\",\"Level\":5,\"Quality\":0.45,\"Modifiers\":[{\"Label\":\"Mass\",\"Value\":52,\"OriginalValue\":40},{\"Label\":\"Integrity\",\"Value\":96.05,\"OriginalValue\":113},{\"Label\":\"PowerDraw\",\"Value\":0.575,\"OriginalValue\":0.5},{\"Label\":\"FSDOptimalMass\",\"Value\":1794,\"OriginalValue\":1200}]}},{\"Slot\":\"LifeSupport\",\"Item\":\"int_lifesupport_size5_class1\",\"On\":true,\"Priority\":0,\"Value\":31780},{\"Slot\":\"PowerDistributor\",\"Item\":\"int_powerdistributor_size8_class1\",\"On\":true,\"Priority\":0,\"Value\":697580},{\"Slot\":\"Radar\",\"Item\":\"int_sensors_size8_class1\",\"On\":true,\"Priority\":0,\"Value\":697580},{\"Slot\":\"FuelTank\",\"Item\":\"int_fueltank_size5_class3\",\"On\":true,\"Priority\":0,\"Value\":97750},{\"Slot\":\"Slot01_Size7\",\"Item\":\"int_fueltank_size7_class3\",\"On\":true,\"Priority\":0,\"Value\":1780910},{\"Slot\":\"Slot02_Size7\",\"Item\":\"int_fueltank_size7_class3\",\"On\":true,\"Priority\":0,\"Value\":1780910},{\"Slot\":\"Slot03_Size7\",\"Item\":\"int_fueltank_size7_class3\",\"On\":true,\"Priority\":0,\"Value\":1780910},{\"Slot\":\"Slot04_Size6\",\"Item\":\"int_fueltank_size6_class3\",\"On\":true,\"Priority\":0,\"Value\":341580},{\"Slot\":\"Slot05_Size6\",\"Item\":\"int_fueltank_size6_class3\",\"On\":true,\"Priority\":0,\"Value\":341580},{\"Slot\":\"Slot06_Size5\",\"Item\":\"int_fueltank_size5_class3\",\"On\":true,\"Priority\":0,\"Value\":97750},{\"Slot\":\"Slot07_Size5\",\"Item\":\"int_fueltank_size5_class3\",\"On\":true,\"Priority\":0,\"Value\":97750},{\"Slot\":\"Slot08_Size4\",\"Item\":\"int_fueltank_size4_class3\",\"On\":true,\"Priority\":0,\"Value\":24730},{\"Slot\":\"Slot09_Size4\",\"Item\":\"int_fueltank_size4_class3\",\"On\":true,\"Priority\":0,\"Value\":24730},{\"Slot\":\"Slot10_Size3\",\"Item\":\"int_fueltank_size3_class3\",\"On\":true,\"Priority\":0,\"Value\":7060},{\"Slot\":\"Slot11_Size1\",\"Item\":\"int_fuelscoop_size1_class5\",\"On\":true,\"Priority\":0,\"Value\":82270}]}}]",
                max_time = 60,
                cargo = 0,
                algorithm = Algorithm.optimistic,
            };
        }

        public void testColonizationRoute(string targetSystem)
        {
            Game.spansh.generateColonizationRoute(targetSystem).continueOnSuccess(route =>
            {
                var txt = route?.result.jumps.Skip(1).Select((j, n) => $"#{n + 1} {j.name} ({j.distance:N2}ly)").formatWithHeader($"Best route: {route.result.jumps.Count - 1} hops", "\r\n\t");
                Game.log(txt ?? "??");
                Game.log("--*--");
            });
        }

        /// <summary>
        /// Finds the nearest populated systems to a given target colonization system, and attempts to find the best 10ly hop route to it
        /// </summary>
        public async Task<GalaxyRoute?> generateColonizationRoute(string targetSystem)
        {
            // find nearest systems to start from
            // TODO: really this should be a search for stations owned by the faction
            var q = new SystemQuery
            {
                page = 0,
                size = 2,
                reference_system = targetSystem,
                sort = new() { new("distance", SortOrder.asc) },
                filters = new() {
                    { "minor_faction_presences", new SystemQuery.Values("Raven Colonial Corporation") },
                }
            };
            var response = await this.querySystems(q);
            var startSystem1 = response.results?.FirstOrDefault()?.name;
            var startSystem2 = response.results?.LastOrDefault()?.name;

            if (startSystem1 == null)
            {
                Game.log(": generateColonizationRouteNo suitable systems?");
                return null;
            }
            Game.log($"generateColonizationRoute: from '{targetSystem}' => '{startSystem1}' or '{startSystem2}'");

            // kick off one job, or ...
            if (startSystem2 == null || startSystem2 == startSystem1)
            {
                var route = await getColonizationRoute(targetSystem, startSystem1);
                return route;
            }

            // ... two jobs to generate two routes
            var task1 = getColonizationRoute(startSystem1, targetSystem);
            var task2 = getColonizationRoute(startSystem2, targetSystem);

            var routes = await Task.WhenAll(task1, task2);
            if (routes?[0]?.result.jumps.Count <= routes?[1]?.result.jumps.Count)
                return routes?[0];
            else
                return routes?[1];
        }

        public async Task<GalaxyRoute?> getColonizationRoute(string targetSystem, string sourceSystem)
        {
            Game.log($"getColonizationRoute: generating: '{targetSystem}' => '{sourceSystem}' ... ");

            var req = GalaxyRouteRequest.ColonyHopper;
            req.source = sourceSystem;
            req.destination = targetSystem;

            var jobId = await createGalaxyRoute(req);
            Game.log($"getColonizationRoute: '{targetSystem}' => '{sourceSystem}' => {jobId}");

            // wait ~30 seconds, then start polling for a result
            await Task.Delay(30_000);

            var route = await getRoute<GalaxyRoute>(jobId, req.max_time);
            Game.log($"getColonizationRoute: '{targetSystem}' => '{sourceSystem}' => {jobId} => {route?.result.jumps.Count - 1} hops");
            return route;
        }
    }
}
