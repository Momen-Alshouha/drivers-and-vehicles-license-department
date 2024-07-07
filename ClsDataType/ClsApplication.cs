using System;
using static ClsDataType.ClsDataType;

namespace ClsDataType
{
    public class ClsApplication
    {
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

            public StApplicationData()
            {
                EnApplicationType = EnApplicationType.NewLocalDrivingLicenseService;
                EnApplicationStatus = EnApplicationStatus.New;
                StatusText = "NEW";
                ApplicationType = "New Local Driving License Service";
            }

            public StApplicationData(StApplicationData applicationData)
            {
                StApplicationTypeInfo = applicationData.StApplicationTypeInfo;
                ApplicationTypeID = applicationData.ApplicationTypeID;
                ApplicationID = applicationData.ApplicationID;
                ApplicationStatus = applicationData.ApplicationStatus;
                EnApplicationType = _GetEnAppType(applicationData.ApplicationTypeID);
                EnApplicationStatus = _GetEnAppStatus(applicationData.ApplicationStatus);
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

            private static EnApplicationStatus _GetEnAppStatus(int applicationStatus)
            {
                return applicationStatus switch
                {
                    1 => EnApplicationStatus.New,
                    2 => EnApplicationStatus.Canceled,
                    3 => EnApplicationStatus.Completed,
                    _ => throw new ArgumentOutOfRangeException(nameof(applicationStatus), "Invalid application status ID")
                };
            }

            private static EnApplicationType _GetEnAppType(int applicationTypeID)
            {
                return applicationTypeID switch
                {
                    1 => EnApplicationType.NewLocalDrivingLicenseService,
                    2 => EnApplicationType.RenewDrivingLicenseService,
                    3 => EnApplicationType.ReplacementForLostDrivingLicense,
                    4 => EnApplicationType.ReplacementForDamagedDrivingLicense,
                    5 => EnApplicationType.ReleaseDetainedDrivingLicense,
                    6 => EnApplicationType.NewInternationalLicense,
                    7 => EnApplicationType.RetakeTest,
                    _ => throw new ArgumentOutOfRangeException(nameof(applicationTypeID), "Invalid application type ID")
                };
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
