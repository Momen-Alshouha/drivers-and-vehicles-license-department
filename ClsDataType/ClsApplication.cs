using System;
using static ClsDataType.ClsApplication;
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

        public struct StLocalDrivindLicenseApplication
        {
            public int LocalDrivingLicenseApplicationID;
            public int ApplicationID;
            public decimal LicenseClassID;
        }

        public struct StApplicationData
        {
            public EnApplicationType enApplicationType { get; set; }
            public EnApplicationStatus EnApplicationStatus { get; set; }
            public StApplicationType StApplicationTypeInfo { get; set; }
            public int ApplicationID { get; set; }
            public string ApplicantFullName { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public decimal PaidFees { get; set; }
            public string StatusText { get; private set; }
            public string ApplicationType { get; private set; }
            public StUser CreatedByUser { get; set; }
            public StPerson stPerson { get; set; }
            public int LicenseClassID;
            public EnLicenseClass enLicenseClass { get; set; }
            public string LicenseClassText { get; set; }

            public StApplicationData()
            {
                enApplicationType = EnApplicationType.NewLocalDrivingLicenseService;
                EnApplicationStatus = EnApplicationStatus.New;
                StatusText = "NEW";
                ApplicationType = "New Local Driving License Service";
            }

            public StApplicationData(StApplicationData applicationData)
            {
                LicenseClassID =applicationData.LicenseClassID;
                enLicenseClass = (EnLicenseClass)applicationData.LicenseClassID;
                LicenseClassText = _GetLicenseClassText(enLicenseClass);

                ApplicationStatus = applicationData.ApplicationStatus;
                EnApplicationStatus =(EnApplicationStatus)applicationData.ApplicationStatus;
                StatusText = _GetApplicationStatusText(applicationData.EnApplicationStatus);


                ApplicationType = applicationData.ApplicationType;
                enApplicationType = (EnApplicationType)applicationData.StApplicationTypeInfo.id;
                ApplicationType = _GetApplicationTypeText(applicationData.enApplicationType);

                LastStatusDate = DateTime.Now;
                
                StApplicationTypeInfo = applicationData.StApplicationTypeInfo;
               
                ApplicationID = applicationData.ApplicationID;
                stPerson = applicationData.stPerson;

                CreatedByUser = applicationData.CreatedByUser;

                ApplicationDate = applicationData.ApplicationDate;
                LastStatusDate = applicationData.LastStatusDate;
                PaidFees = applicationData.PaidFees;

                
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

            private static string _GetLicenseClassText(EnLicenseClass licenseClass)
            {
                return licenseClass switch
                {
                    EnLicenseClass.SmallMotorcycle => "Small Motorcycle",
                    EnLicenseClass.HeavyMotorcycle => "Heavy Motorcycle",
                    EnLicenseClass.OrdinaryDriving => "Ordinary Driving",
                    EnLicenseClass.Commercial => "Commercial",
                    EnLicenseClass.Agricultural => "Agricultural",
                    EnLicenseClass.SmallMediumBus => "Small/Medium Bus",
                    EnLicenseClass.TruckHeavyVehicle => "Truck/Heavy Vehicle",
                    _ => "Unknown License Class"
                };
            }

        }
    }
}
