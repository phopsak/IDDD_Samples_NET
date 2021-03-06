﻿// Copyright 2012,2013 Vaughn Vernon
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace SaaSOvation.IdentityAccess.Domain.Model.Identity
{
    public class UserDescriptor
    {
        public static UserDescriptor NullDescriptorInstance()
        {
            return new UserDescriptor();
        }

        public UserDescriptor(TenantId tenantId, string username, string emailAddress)
        {
            this.EmailAddress = emailAddress;
            this.TenantId = tenantId;
            this.Username = username;
        }

        private UserDescriptor()
        {
        }

        public string EmailAddress { get; private set; }

        public TenantId TenantId { get; private set; }

        public string Username { get; private set; }

        public override bool Equals(object anotherObject)
        {
            bool equalObjects = false;

            if (anotherObject != null && this.GetType() == anotherObject.GetType()) {
                UserDescriptor typedObject = (UserDescriptor) anotherObject;
                equalObjects =
                        this.EmailAddress.Equals(typedObject.EmailAddress) &&
                        this.TenantId.Equals(typedObject.TenantId) &&
                        this.Username.Equals(typedObject.Username);
            }

            return equalObjects;
        }

        public override int GetHashCode()
        {
            int hashCodeValue =
                + (9429 * 263)
                + this.EmailAddress.GetHashCode()
                + this.TenantId.GetHashCode()
                + this.Username.GetHashCode();

            return hashCodeValue;
        }

        public override string ToString()
        {
            return "UserDescriptor [emailAddress=" + EmailAddress
                    + ", tenantId=" + TenantId + ", username=" + Username + "]";
        }
    }
}
