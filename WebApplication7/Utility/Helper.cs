using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";
        public static string appointmentAdded = "Appointment added successfuly.";
        public static string appointmentUpdated = "Appointment updated successfuly.";
        public static string appointmentDeleted = "Appointment deleted successfuly.";
        public static string appointmentExists = "Appointment already exists.";
        public static string appointmentNotExists = "Appointment does not exist.";
        public static string meetingConfirm = "Meeting confirmed successfully.";
        public static string meetingConfirmError = "Error while confirming meeting.";
        public static string appointmentAddError = "Something went wrong, try again.";
        public static string appointmentUpdatError = "Something went wrong, try again.";
        public static string somethingWentWrong = "Something went wrong, try again.";
        public static int success_code = 1;
        public static int failure_code = 0;
        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Admin,Text=Helper.Admin},
                new SelectListItem{Value=Helper.Patient,Text=Helper.Patient},
                new SelectListItem{Value=Helper.Doctor,Text=Helper.Doctor},
            };
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 60;
            List<SelectListItem> duration = new List<SelectListItem>();
            for (int i = 1; i <= 12; i++)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + "Hr " });
                minute = minute + 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hr 30 min" });
            }
            return duration;
        }
    }
}
