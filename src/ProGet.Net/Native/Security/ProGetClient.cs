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
        /// Grants or denies the specified principal the ability to perform a certain role
        /// </summary>
        /// <returns>Privilege_Id</returns>
        public async Task<int> Security_AddPrivilegeAsync(
            int privilege_Id,
            int userDirectory_Id,
            string principal_Name,
            string principalType_Code,
            int role_Id,
            int feed_Id,
            string privilegeType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(privilege_Id).Capitalize(), privilege_Id),
                new NamedValue(nameof(userDirectory_Id).Capitalize(), userDirectory_Id),
                new NamedValue(nameof(principal_Name).Capitalize(), principal_Name),
                new NamedValue(nameof(principalType_Code).Capitalize(), principalType_Code),
                new NamedValue(nameof(role_Id).Capitalize(), role_Id),
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(privilegeType_Code).Capitalize(), privilegeType_Code)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Security_AddPrivilegeAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates or updates a role
        /// </summary>
        /// <returns>Role_Id</returns>
        public async Task<int> Security_CreateOrUpdateRoleAsync(
            int role_Id,
            string role_Name,
            string role_Description,
            string tasks_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(role_Id).Capitalize(), role_Id),
                new NamedValue(nameof(role_Name).Capitalize(), role_Name),
                new NamedValue(nameof(role_Description).Capitalize(), role_Description),
                new NamedValue(nameof(tasks_Csv).Capitalize(), tasks_Csv)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Security_CreateOrUpdateRoleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified role
        /// </summary>
        public async Task<bool> Security_DeleteRoleAsync(int role_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(role_Id).Capitalize(), role_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Security_DeleteRoleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of privileges assigned in the system
        /// </summary>
        public async Task<IEnumerable<PrivilegesExtended>> Security_GetPrivilegesAsync(
            int userDirectory_Id,
            string principalType_Code)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(userDirectory_Id).Capitalize(), userDirectory_Id),
                new NamedValue(nameof(principalType_Code).Capitalize(), principalType_Code)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<PrivilegesExtended>>(nameof(Security_GetPrivilegesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified role in the database, along with all the tasks that comprise the role
        /// </summary>
        public async Task<RolesRoleTasksExtended> Security_GetRoleAsync(int role_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(role_Id).Capitalize(), role_Id)
            );

            return await ExecuteNativeApiMethodAsync<RolesRoleTasksExtended>(nameof(Security_GetRoleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the roles in the system, along with all the tasks comprising each role
        /// </summary>
        public async Task<RolesRoleTasksExtended> Security_GetRolesAsync() => 
            await ExecuteNativeApiMethodAsync<RolesRoleTasksExtended>(nameof(Security_GetRolesAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets all of the tasks in the system
        /// </summary>
        public async Task<IEnumerable<Tasks>> Security_GetTasksAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<Tasks>>(nameof(Security_GetTasksAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets the list of privileges specifically assigned to a user or any specified groups
        /// </summary>
        public async Task<IEnumerable<PrivilegesExtended>> Security_GetUserPrivilegesAsync(
            int userDirectory_Id,
            string user_Name,
            string groupNames_Csv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(userDirectory_Id).Capitalize(), userDirectory_Id),
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(groupNames_Csv).Capitalize(), groupNames_Csv)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<PrivilegesExtended>>(nameof(Security_GetUserPrivilegesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a privilege
        /// </summary>
        public async Task<bool> Security_RemovePrivilegeAsync(int privilege_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(privilege_Id).Capitalize(), privilege_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Security_RemovePrivilegeAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
