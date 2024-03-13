using System;
using System.Collections.Generic;

namespace Race
{
    enum MenuOptions
    {
        HEADING_Race_Control,
        Start_race,
        Stop_race,
        Pause_race,
        Start_all_vehicles,
        Stop_all_vehicles,

        HEADING_Race_Admin,
        Add_team,
        Remove_team,
        Edit_team,
        Add_circuit,
        Remove_circuit,
        Edit_circuit,
        Show_results,
        Statistics,
        Show_all_vehicles,
        Show_vehicles_in_each_team,
        Show_vehicles_not_assigned_to_any_team,
        Show_all_teams,
        Show_all_circuits,

        HEADING_Team_Admin,
        Add_vehicle,
        Edit_vehicle,
        Remove_vehicle,

        HEADING_Other,
        Exit,
    }
}
