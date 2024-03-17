using System;
using System.Collections.Generic;

namespace Race
{
    enum MenuOptions
    {
        HEADING_Race_Control,
        Start_race,

        HEADING_Race_Admin,
        IGNORE_Add_team,
        IGNORE_Remove_team,
        IGNORE_Edit_team,
        IGNORE_Add_circuit,
        IGNORE_Remove_circuit,
        IGNORE_Edit_circuit,
        IGNORE_Show_results,
        Statistics,
        Show_all_vehicles,
        Show_vehicles_in_each_team,
        Show_all_teams,
        Show_all_circuits,

        HEADING_Team_Admin,
        IGNORE_Add_vehicle,
        IGNORE_Edit_vehicle,
        IGNORE_Remove_vehicle,

        HEADING_Other,
        Exit,
    }
}
