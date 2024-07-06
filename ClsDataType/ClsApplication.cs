using System;

namespace ClsDataType
{
    public class ClsApplication
    {
        public enum EnApplicationType
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForLostDrivingLicense = 3,
            ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }

        public enum EnApplicationStatus
        {
            New = 1,
            Canceled = 2,
            Completed = 3
        }
        public struct StApplicationTypeInfo
        {
            public int ApplicationTypeID;
            public string ApplicationTypeTitle;
            public decimal ApplicationFees;
        }
        public struct StApplicationData
        {
            EnApplicationType EnApplicationType;
            EnApplicationStatus EnApplicationStatus;
            StApplicationTypeInfo StApplicationTypeInfo;
            public int ApplicationID { get; set; }
            public int ApplicantPersonID { get; set; }
            public string ApplicantFullName;
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public int ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public decimal PaidFees { get; set; }
            public int CreatedByUserID { get; set; }
            public string StatusText;
            public string ApplicationType;

            public StApplicationData() { }

            public StApplicationData(StApplicationData applicationData)
            {
                this.StApplicationTypeInfo = applicationData.StApplicationTypeInfo;
                this.ApplicationTypeID = applicationData.ApplicationTypeID;
                this.ApplicationID = applicationData.ApplicationID;
                this.ApplicationStatus = applicationData.ApplicationStatus;
                this.EnApplicationType = _GetEnAppType(this.ApplicationTypeID);
                this.EnApplicationStatus = _GetEnAppStatus(this.ApplicationStatus);
                this.ApplicantPersonID = applicationData.ApplicantPersonID;
                this.LastStatusDate = applicationData.LastStatusDate;
                this.PaidFees = applicationData.PaidFees;
                this.CreatedByUserID = applicationData.CreatedByUserID;
                this.StatusText = _GetStatusText(applicationData.EnApplicationStatus);
                this.ApplicationType = _GetApplicationTypeText(applicationData.EnApplicationType);
            }
            private EnApplicationStatus _GetEnAppStatus(int ApplicationStatus)
            {
                switch (ApplicationStatus)
                {
                    case 1:
                        return EnApplicationStatus.New;
                    case 2:
                            return EnApplicationStatus.Canceled;
                    case 3:
                        return EnApplicationStatus.Completed;
                    default:
                        return EnApplicationStatus.New;
                }
            }
            private EnApplicationType _GetEnAppType(int ApplicationTypeID)
            {

                switch (ApplicationTypeID)
                {
                    case 1:
                        return EnApplicationType.NewLocalDrivingLicenseService;
                    case 2:
                        return EnApplicationType.RenewDrivingLicenseService;
                    case 3:
                        return EnApplicationType.ReplacementForLostDrivingLicense;
                    case 4:
                        return EnApplicationType.ReplacementForDamagedDrivingLicense;
                    case 5:
                        return EnApplicationType.ReleaseDetainedDrivingLicense;
                    case 6:
                        return EnApplicationType.NewInternationalLicense;
                    case 7:
                        return EnApplicationType.RetakeTest;
                    default:
                        return EnApplicationType.NewLocalDrivingLicenseService;
                }
            }
            private string _GetStatusText(EnApplicationStatus applicationStatus)
            {
                switch (applicationStatus)
                {
                    case EnApplicationStatus.New:
                        return "NEW";
                    case EnApplicationStatus.Canceled:
                        return "CANCLED";
                    case EnApplicationStatus.Completed:
                        return "COMPLETED";
                    default:
                        return "UNKNOWN";
                }
            }

            private static string _GetApplicationTypeText(EnApplicationType applicationType)
            {
                switch (applicationType)
                {
                    case EnApplicationType.NewLocalDrivingLicenseService:
                        return "New Local Driving License Service";
                    case EnApplicationType.RenewDrivingLicenseService:
                        return "Renew Driving License Service";
                    case EnApplicationType.ReplacementForLostDrivingLicense:
                        return "Replacement for Lost Driving License";
                    case EnApplicationType.ReplacementForDamagedDrivingLicense:
                        return "Replacement for Damaged Driving License";
                    case EnApplicationType.ReleaseDetainedDrivingLicense:
                        return "Release Detained Driving License";
                    case EnApplicationType.NewInternationalLicense:
                        return "New International License";
                    case EnApplicationType.RetakeTest:
                        return "Retake Test";
                    default:
                        return "Unknown Application Type";
                }
            }
        }

    }
}
