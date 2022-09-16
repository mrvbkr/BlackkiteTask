using System;
using System.Collections.Generic;
using System.Text;

namespace BlackKiteTask.Models
{
    class Enums
    {
        public enum RoleEnum
        {
            SuperAdmin,
            EcosystemAdmin,
            CompanyAdmin,
            SuperUser,
            EcosystemUser,
            CompanyUser
        }

        public enum TypeEnum
        {
            Normal,
            Group
        }

        public enum GradeLetterEnum
        {

            A_PLUS,
            A,
            A_MINUS,
            B_PLUS,
            B,
            B_MINUS,
            C_PLUS,
            C,
            C_MINUS,
            D_PLUS,
            D,
            D_MINUS,
            F
        }

        public enum ScanStatusEnum
        {
            Preliminary_Scan_Queued,
            Preliminary_Scan_Running,
            Preliminary_Scan_Failed,
            Preliminary_Results_Ready,
            Extended_Scan_Queued,
            Extended_Scan_Running,
            Extended_Scan_Failed,
            Extended_Results_Ready,
            Extended_Rescan_Queued,
            Extended_Rescan_Running,
            Extended_Rescan_Failed,
            Extended_Rescan_Results_Ready,
            Unknown_Scan_Status
        }




    }
}
