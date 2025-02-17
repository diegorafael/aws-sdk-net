/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Transfer
{

    /// <summary>
    /// Constants used for properties of type CustomStepStatus.
    /// </summary>
    public class CustomStepStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE for CustomStepStatus
        /// </summary>
        public static readonly CustomStepStatus FAILURE = new CustomStepStatus("FAILURE");
        /// <summary>
        /// Constant SUCCESS for CustomStepStatus
        /// </summary>
        public static readonly CustomStepStatus SUCCESS = new CustomStepStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomStepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomStepStatus FindValue(string value)
        {
            return FindValue<CustomStepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomStepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Domain.
    /// </summary>
    public class Domain : ConstantClass
    {

        /// <summary>
        /// Constant EFS for Domain
        /// </summary>
        public static readonly Domain EFS = new Domain("EFS");
        /// <summary>
        /// Constant S3 for Domain
        /// </summary>
        public static readonly Domain S3 = new Domain("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Domain(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Domain FindValue(string value)
        {
            return FindValue<Domain>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Domain(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {

        /// <summary>
        /// Constant PUBLIC for EndpointType
        /// </summary>
        public static readonly EndpointType PUBLIC = new EndpointType("PUBLIC");
        /// <summary>
        /// Constant VPC for EndpointType
        /// </summary>
        public static readonly EndpointType VPC = new EndpointType("VPC");
        /// <summary>
        /// Constant VPC_ENDPOINT for EndpointType
        /// </summary>
        public static readonly EndpointType VPC_ENDPOINT = new EndpointType("VPC_ENDPOINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointType FindValue(string value)
        {
            return FindValue<EndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionErrorType.
    /// </summary>
    public class ExecutionErrorType : ConstantClass
    {

        /// <summary>
        /// Constant PERMISSION_DENIED for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType PERMISSION_DENIED = new ExecutionErrorType("PERMISSION_DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionErrorType FindValue(string value)
        {
            return FindValue<ExecutionErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus COMPLETED = new ExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant EXCEPTION for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus EXCEPTION = new ExecutionStatus("EXCEPTION");
        /// <summary>
        /// Constant HANDLING_EXCEPTION for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus HANDLING_EXCEPTION = new ExecutionStatus("HANDLING_EXCEPTION");
        /// <summary>
        /// Constant IN_PROGRESS for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus IN_PROGRESS = new ExecutionStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HomeDirectoryType.
    /// </summary>
    public class HomeDirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant LOGICAL for HomeDirectoryType
        /// </summary>
        public static readonly HomeDirectoryType LOGICAL = new HomeDirectoryType("LOGICAL");
        /// <summary>
        /// Constant PATH for HomeDirectoryType
        /// </summary>
        public static readonly HomeDirectoryType PATH = new HomeDirectoryType("PATH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HomeDirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HomeDirectoryType FindValue(string value)
        {
            return FindValue<HomeDirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HomeDirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityProviderType.
    /// </summary>
    public class IdentityProviderType : ConstantClass
    {

        /// <summary>
        /// Constant API_GATEWAY for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType API_GATEWAY = new IdentityProviderType("API_GATEWAY");
        /// <summary>
        /// Constant AWS_DIRECTORY_SERVICE for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType AWS_DIRECTORY_SERVICE = new IdentityProviderType("AWS_DIRECTORY_SERVICE");
        /// <summary>
        /// Constant AWS_LAMBDA for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType AWS_LAMBDA = new IdentityProviderType("AWS_LAMBDA");
        /// <summary>
        /// Constant SERVICE_MANAGED for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType SERVICE_MANAGED = new IdentityProviderType("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProviderType FindValue(string value)
        {
            return FindValue<IdentityProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverwriteExisting.
    /// </summary>
    public class OverwriteExisting : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for OverwriteExisting
        /// </summary>
        public static readonly OverwriteExisting FALSE = new OverwriteExisting("FALSE");
        /// <summary>
        /// Constant TRUE for OverwriteExisting
        /// </summary>
        public static readonly OverwriteExisting TRUE = new OverwriteExisting("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverwriteExisting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverwriteExisting FindValue(string value)
        {
            return FindValue<OverwriteExisting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverwriteExisting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant FTP for Protocol
        /// </summary>
        public static readonly Protocol FTP = new Protocol("FTP");
        /// <summary>
        /// Constant FTPS for Protocol
        /// </summary>
        public static readonly Protocol FTPS = new Protocol("FTPS");
        /// <summary>
        /// Constant SFTP for Protocol
        /// </summary>
        public static readonly Protocol SFTP = new Protocol("SFTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant OFFLINE for State
        /// </summary>
        public static readonly State OFFLINE = new State("OFFLINE");
        /// <summary>
        /// Constant ONLINE for State
        /// </summary>
        public static readonly State ONLINE = new State("ONLINE");
        /// <summary>
        /// Constant START_FAILED for State
        /// </summary>
        public static readonly State START_FAILED = new State("START_FAILED");
        /// <summary>
        /// Constant STARTING for State
        /// </summary>
        public static readonly State STARTING = new State("STARTING");
        /// <summary>
        /// Constant STOP_FAILED for State
        /// </summary>
        public static readonly State STOP_FAILED = new State("STOP_FAILED");
        /// <summary>
        /// Constant STOPPING for State
        /// </summary>
        public static readonly State STOPPING = new State("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStepType.
    /// </summary>
    public class WorkflowStepType : ConstantClass
    {

        /// <summary>
        /// Constant COPY for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType COPY = new WorkflowStepType("COPY");
        /// <summary>
        /// Constant CUSTOM for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType CUSTOM = new WorkflowStepType("CUSTOM");
        /// <summary>
        /// Constant DELETE for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType DELETE = new WorkflowStepType("DELETE");
        /// <summary>
        /// Constant TAG for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType TAG = new WorkflowStepType("TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStepType FindValue(string value)
        {
            return FindValue<WorkflowStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStepType(string value)
        {
            return FindValue(value);
        }
    }

}