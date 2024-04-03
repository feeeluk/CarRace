using System;
using System.Collections.Generic;

namespace Race.Objects.Menus
{
    enum MenuOptions
    {
        HEADING_Race_Director,
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
        List_all_Vehicles,
        List_Vehicles_by_Team,
        List_all_Teams,
        List_all_Circuits,
        Add_Circuit,
        Show_all_results,
        Show_Vehicle_leaderboard,
        Show_Constructor_leaderboard,
        HEADING_Team_Admin,
        Add_vehicle,
        IGNORE_Edit_vehicle,
        IGNORE_Remove_vehicle,

        HEADING_Other,
        Exit,
    }
}
