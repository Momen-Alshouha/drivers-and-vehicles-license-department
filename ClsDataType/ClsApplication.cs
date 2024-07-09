using System;
using static ClsDataType.ClsDataType;

namespace ClsDataType
{
    public class ClsApplication
    {
        public enum EnLicenseClass
        {
            SmallMotorcycle = 1,
            HeavyMotorcycle,
            OrdinaryDriving,
            Commercial,
            Agricultural,
            SmallMediumBus,
            TruckHeavyVehicle 
        }
    

        public enum EnApplicationType
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService,
            ReplacementForLostDrivingLicense,
            ReplacementForDamagedDrivingLicense,
            ReleaseDetainedDrivingLicense,
            NewInternationalLicense,
            RetakeTest
        }

        public enum EnApplicationStatus
        {
            New = 1,
            Canceled,
            Completed
        }

        public struct StApplicationTypeInfo
        {
            public int ApplicationTypeID;
            public string ApplicationTypeTitle;
            public decimal ApplicationFees;
        }

        public struct StLocalDrivindLicenseApplication
        {
            public int LocalDrivingLicenseApplicationID;
            public int ApplicationID;
            public decimal LicenseClassID;
        }

        public struct StApplicationData
        {
            public EnApplicationType EnApplicationType { get; set; }
            public EnApplicationStatus EnApplicationStatus { get; set; }
            public StApplicationTypeInfo StApplicationTypeInfo { get; set; }
            public int ApplicationID { get; set; }
            public int ApplicantPersonID { get; set; }
            public string ApplicantFullName { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public int ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public decimal PaidFees { get; set; }
            public int CreatedByUserID { get; set; }
            public string StatusText { get; private set; }
            public string ApplicationType { get; private set; }
            public StUser CreatedByUser { get; set; }
            public int LicenseClassID;
            public EnLicenseClass enLicenseClass { get; set; }

            public StApplicationData()
            {
                EnApplicationType = EnApplicationType.NewLocalDrivingLicenseService;
                EnApplicationStatus = EnApplicationStatus.New;
                StatusText = "NEW";
                ApplicationType = "New Local Driving License Service";
            }

            public StApplicationData(StApplicationData applicationData)
            {
                LicenseClassID = (int)applicationData.enLicenseClass;
                LastStatusDate = DateTime.Now;
                StApplicationTypeInfo = applicationData.StApplicationTypeInfo;
                ApplicationTypeID = (int)applicationData.EnApplicationType;
                ApplicationID = applicationData.ApplicationID;
                ApplicationStatus = (int)applicationData.EnApplicationStatus;
                EnApplicationType = applicationData.EnApplicationType;
                EnApplicationStatus = applicationData.EnApplicationStatus;
                ApplicantPersonID = applicationData.ApplicantPersonID;
                ApplicantFullName = applicationData.ApplicantFullName;
                ApplicationDate = applicationData.ApplicationDate;
                LastStatusDate = applicationData.LastStatusDate;
                PaidFees = applicationData.PaidFees;
                CreatedByUserID = applicationData.CreatedByUserID;
                StatusText = _GetApplicationStatusText(applicationData.EnApplicationStatus);
                ApplicationType = _GetApplicationTypeText(applicationData.EnApplicationType);
                CreatedByUser = applicationData.CreatedByUser;
            }

            private static string _GetApplicationStatusText(EnApplicationStatus applicationStatus)
            {
                return applicationStatus switch
                {
                    EnApplicationStatus.New => "NEW",
                    EnApplicationStatus.Canceled => "CANCELED",
                    EnApplicationStatus.Completed => "COMPLETED",
                    _ => "UNKNOWN"
                };
            }

            private static string _GetApplicationTypeText(EnApplicationType applicationType)
            {
                return applicationType switch
                {
                    EnApplicationType.NewLocalDrivingLicenseService => "New Local Driving License Service",
                    EnApplicationType.RenewDrivingLicenseService => "Renew Driving License Service",
                    EnApplicationType.ReplacementForLostDrivingLicense => "Replacement for Lost Driving License",
                    EnApplicationType.ReplacementForDamagedDrivingLicense => "Replacement for Damaged Driving License",
                    EnApplicationType.ReleaseDetainedDrivingLicense => "Release Detained Driving License",
                    EnApplicationType.NewInternationalLicense => "New International License",
                    EnApplicationType.RetakeTest => "Retake Test",
                    _ => "Unknown Application Type"
                };
            }
        }
    }
}
