using System.Collections.Generic;
using System.Threading.Tasks;
using ProGet.Net.Common;
using ProGet.Net.Native.Models;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        /// <summary>
        /// Creates a new user group
        /// </summary>
        public async Task<bool> Users_CreateGroupAsync(string group_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name)
            );

            var response = await ExecuteNativeApiMethodAsync(nameof(Users_CreateGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);

            return response; //TODO: inline
        }

        /// <summary>
        /// Creates or modifies a user
        /// </summary>
        public async Task<bool> Users_CreateOrUpdateUserAsync(
            string user_Name,
            string display_Name,
            string email_Address,
            string groups_Xml)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(display_Name).Capitalize(), display_Name),
                new NamedValue(nameof(email_Address).Capitalize(), email_Address),
                new NamedValue(nameof(groups_Xml).Capitalize(), groups_Xml)
            );

            var response = await ExecuteNativeApiMethodAsync(nameof(Users_CreateOrUpdateUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);

            return response; //TODO: inline
        }

        /// <summary>
        /// Deletes a user group from the system, but does not delete the users who belong to the group
        /// </summary>
        public async Task<bool> Users_DeleteGroupAsync(string group_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name)
            );

            var response = await ExecuteNativeApiMethodAsync(nameof(Users_DeleteGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);

            return response; //TODO: inline
        }

        /// <summary>
        /// Deletes a user
        /// </summary>
        public async Task<bool> Users_DeleteUserAsync(string group_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name)
            );

            var response = await ExecuteNativeApiMethodAsync(nameof(Users_DeleteUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);

            return response; //TODO: inline
        }

        /// <summary>
        /// Gets a list of user groups in the system
        /// </summary>
        public async Task<IEnumerable<Group>> Users_GetGroupsAsync()
        {
            var response = await ExecuteNativeApiMethodAsync<IEnumerable<Group>>(nameof(Users_GetGroupsAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

            return response; //TODO: inline
        }

        /// <summary>
        /// Gets the details of the specified user, and a list of all the groups the user belongs to
        /// </summary>
        public async Task<UsersUserGroups> Users_GetUserAsync(string user_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(user_Name).Capitalize(), user_Name)
            );

            var response = await ExecuteNativeApiMethodAsync<UsersUserGroups>(nameof(Users_GetUserAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);

            return response; //TODO: inline
        }

        /// <summary>
        /// Gets all the users in the system, along with all the groups in the system
        /// </summary>
        public async Task<UsersUserGroups> Users_GetUsersAsync()
        {
            var response = await ExecuteNativeApiMethodAsync<UsersUserGroups>(nameof(Users_GetUsersAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

            return response; //TODO: inline
        }

        /// <summary>
        /// Gets a list of users in the specified group
        /// </summary>
        public async Task<IEnumerable<User>> Users_GetUsersInGroupAsync(string group_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group_Name).Capitalize(), group_Name)
            );

            var response = await ExecuteNativeApiMethodAsync<IEnumerable<User>>(nameof(Users_GetUsersInGroupAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);

            return response; //TODO: inline
        }
    }
}
