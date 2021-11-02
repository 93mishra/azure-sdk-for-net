// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> A single exception rule. </summary>
    public partial class ExceptionRule
    {
        /// <summary> Initializes a new instance of ExceptionRule. </summary>
        /// <param name="id"> Unique Id of the rule. </param>
        /// <param name="trigger"> The exception trigger for this exception rule. </param>
        /// <param name="actions"> The actions to perform once the exception is triggered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="trigger"/>, or <paramref name="actions"/> is null. </exception>
        public ExceptionRule(string id, JobExceptionTrigger trigger, IEnumerable<ExceptionAction> actions)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }
            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions));
            }

            Id = id;
            Trigger = trigger;
            Actions = actions.ToList();
        }

        /// <summary> Initializes a new instance of ExceptionRule. </summary>
        /// <param name="id"> Unique Id of the rule. </param>
        /// <param name="trigger"> The exception trigger for this exception rule. </param>
        /// <param name="actions"> The actions to perform once the exception is triggered. </param>
        internal ExceptionRule(string id, JobExceptionTrigger trigger, IList<ExceptionAction> actions)
        {
            Id = id;
            Trigger = trigger;
            Actions = actions;
        }

        /// <summary> Unique Id of the rule. </summary>
        public string Id { get; set; }
        /// <summary> The exception trigger for this exception rule. </summary>
        public JobExceptionTrigger Trigger { get; set; }
        /// <summary> The actions to perform once the exception is triggered. </summary>
        public IList<ExceptionAction> Actions { get; }
    }
}
