using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAddedMessage = "Car added successfully.";
        public static string CarNameInvalidMessage = "The car name should be longer then two letters.";
        public static string CarPriceInvalid = "The daily price cannot be equal or smaller then 0.";
        public static string AddSuccessMessage = "Successfully added.";
        public static string AddFailedMessage = "Adding failed.";
        public static string UpdateSuccessMessage = "Successfully updated.";
        public static string UpdateFailedMessage = "Updating failed.";
        public static string DeleteSuccessMessage = "Deletion successful.";
        public static string DeleteFailedMessage = "Deletion failed.";
        public static string RentationSuccessMessage = "Successfully rented. Have a safe ride.";
        public static string RentationFailedMessage = "Rentation failed.";
        public static string EmailErrorMessage = "E-mail should contain @.";
        public static string CarImageCountExceeded = "Car image count exceeded.";
        public static string UserNotFoundMessage = "User not found.";
        public static string PasswordErrorMessage = "Password is incorrect.";
        public static string SuccessfulLoginMessage = "Login is successful.";
        public static string UserExistMessage = "User already exists.";
        public static string RegisterSuccessfulMessage = "User registered successfully.";
        public static string AccessTokenCreatedMessage = "Access token successfully created.";
    }
}
