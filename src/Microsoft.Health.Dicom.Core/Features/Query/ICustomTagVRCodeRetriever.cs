﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Threading;
using System.Threading.Tasks;
using Dicom;
using Microsoft.Health.Dicom.Core.Models;

namespace Microsoft.Health.Dicom.Core.Features.Query
{
    public interface ICustomTagVRCodeRetriever
    {
       Task<DicomVR> RetrieveAsync(DicomAttributeId attributeId, CancellationToken cancellationToken);
    }
}