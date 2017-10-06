using System.Drawing;
namespace Com.Dropbox.Core.V2.Async
{
    partial class LaunchEmptyResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLaunchEmptyResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LaunchEmptyResult)value, generator);
            }
        }
    }

    partial class LaunchResultBase
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLaunchResultBase(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LaunchResultBase)value, generator);
            }
        }
    }

    partial class PollEmptyResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePollEmptyResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PollEmptyResult)value, generator);
            }
        }
    }

    partial class PollError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePollError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PollError)value, generator);
            }
        }
    }
}

namespace Com.Dropbox.Core.V2.Auth
{
    partial class AccessError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAccessError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AccessError)value, generator);
            }
        }
    }
    partial class InvalidAccountTypeError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeInvalidAccountTypeError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((InvalidAccountTypeError)value, generator);
            }
        }
    }
    partial class PaperAccessError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperAccessError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperAccessError)value, generator);
            }
        }
    }
    partial class RateLimitReason
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRateLimitReason(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RateLimitReason)value, generator);
            }
        }
    }
}

namespace Com.Dropbox.Core.V2.Common
{
    partial class InvalidPathRootError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeInvalidPathRootError(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((InvalidPathRootError)value, generator, collapse);
            }
        }
    }

    partial class PathRootError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePathRootError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PathRootError)value, generator);
            }
        }
    }
}

namespace Com.Dropbox.Core.V2.Sharing
{
    partial class AccessLevel
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAccessLevel(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AccessLevel)value, generator);
            }
        }
    }
    partial class AclUpdatePolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAclUpdatePolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AclUpdatePolicy)value, generator);
            }
        }
    }
    partial class AddFileMemberError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAddFileMemberError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AddFileMemberError)value, generator);
            }
        }
    }
    partial class AddFolderMemberError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAddFolderMemberError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AddFolderMemberError)value, generator);
            }
        }
    }
    partial class AddMemberSelectorError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAddMemberSelectorError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AddMemberSelectorError)value, generator);
            }
        }
    }
    partial class CreateSharedLinkError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeCreateSharedLinkError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((CreateSharedLinkError)value, generator);
            }
        }
    }
    partial class CreateSharedLinkWithSettingsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeCreateSharedLinkWithSettingsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((CreateSharedLinkWithSettingsError)value, generator);
            }
        }
    }
    partial class GetFileMetadataIndividualResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetFileMetadataIndividualResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetFileMetadataIndividualResult)value, generator);
            }
        }
    }
}

namespace Com.Dropbox.Core.V2.Async
{

    partial class PollArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePollArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PollArg)value, generator, collapse);
            }
        }
    }

}


namespace Com.Dropbox.Core.Util
{

}


namespace Com.Dropbox.Core.V2.Auth
{

    partial class RateLimitError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRateLimitError(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RateLimitError)value, generator, collapse);
            }
        }
    }


    partial class TokenFromOAuth1Result
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTokenFromOAuth1Result(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TokenFromOAuth1Result)value, generator, collapse);
            }
        }
    }


    partial class TokenFromOAuth1Error
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTokenFromOAuth1Error(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TokenFromOAuth1Error)value, generator);
            }
        }
    }

}

namespace Com.Dropbox.Core.V2.Sharing
{

    partial class GetSharedLinkFileError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetSharedLinkFileError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetSharedLinkFileError)value, generator);
            }
        }
    }


    partial class LinkPermission
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeLinkPermission(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((LinkPermission)value, generator, collapse);
            }
        }
    }


    partial class GetSharedLinksError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetSharedLinksError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetSharedLinksError)value, generator);
            }
        }
    }


    partial class LinkPermissions
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeLinkPermissions(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((LinkPermissions)value, generator, collapse);
            }
        }
    }


    partial class GetSharedLinksResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetSharedLinksResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetSharedLinksResult)value, generator, collapse);
            }
        }
    }


    partial class AddMember
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAddMember(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AddMember)value, generator, collapse);
            }
        }
    }


    partial class AudienceExceptionContentInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAudienceExceptionContentInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AudienceExceptionContentInfo)value, generator, collapse);
            }
        }
    }


    partial class GroupInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupInfo)value, generator, collapse);
            }
        }
    }


    partial class LinkSettings
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeLinkSettings(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((LinkSettings)value, generator, collapse);
            }
        }
    }


    partial class AudienceExceptions
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAudienceExceptions(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AudienceExceptions)value, generator, collapse);
            }
        }
    }


    partial class ListFileMembersBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFileMembersBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFileMembersBatchResult)value, generator, collapse);
            }
        }
    }


    partial class GroupMembershipInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupMembershipInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupMembershipInfo)value, generator, collapse);
            }
        }
    }


    partial class AudienceRestrictingSharedFolder
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAudienceRestrictingSharedFolder(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AudienceRestrictingSharedFolder)value, generator, collapse);
            }
        }
    }


    partial class InsufficientPlan
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeInsufficientPlan(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((InsufficientPlan)value, generator, collapse);
            }
        }
    }


    partial class ExpectedSharedContentLinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeExpectedSharedContentLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ExpectedSharedContentLinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class CollectionLinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeCollectionLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((CollectionLinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class ListFileMembersContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFileMembersContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFileMembersContinueError)value, generator);
            }
        }
    }


    partial class InsufficientQuotaAmounts
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeInsufficientQuotaAmounts(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((InsufficientQuotaAmounts)value, generator, collapse);
            }
        }
    }


    partial class FileAction
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFileAction(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FileAction)value, generator);
            }
        }
    }


    partial class InviteeInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeInviteeInfo(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((InviteeInfo)value, generator);
            }
        }
    }


    partial class ListFoldersResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFoldersResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFoldersResult)value, generator, collapse);
            }
        }
    }


    partial class ListFileMembersCountResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFileMembersCountResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFileMembersCountResult)value, generator, collapse);
            }
        }
    }


    partial class ListFileMembersError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFileMembersError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFileMembersError)value, generator);
            }
        }
    }


    partial class FileLinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileLinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class FileMemberActionIndividualResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFileMemberActionIndividualResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FileMemberActionIndividualResult)value, generator);
            }
        }
    }


    partial class InviteeMembershipInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeInviteeMembershipInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((InviteeMembershipInfo)value, generator, collapse);
            }
        }
    }


    partial class JobError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeJobError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((JobError)value, generator);
            }
        }
    }


    partial class ListSharedLinksError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListSharedLinksError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListSharedLinksError)value, generator);
            }
        }
    }


    partial class FileMemberActionResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileMemberActionResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileMemberActionResult)value, generator, collapse);
            }
        }
    }


    partial class FileMemberActionError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFileMemberActionError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FileMemberActionError)value, generator);
            }
        }
    }


    partial class ListFileMembersIndividualResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFileMembersIndividualResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFileMembersIndividualResult)value, generator);
            }
        }
    }


    partial class FileMemberRemoveActionResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFileMemberRemoveActionResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FileMemberRemoveActionResult)value, generator);
            }
        }
    }


    partial class ListSharedLinksResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListSharedLinksResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListSharedLinksResult)value, generator, collapse);
            }
        }
    }


    partial class JobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((JobStatus)value, generator);
            }
        }
    }


    partial class LinkAudience
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLinkAudience(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LinkAudience)value, generator);
            }
        }
    }


    partial class ListFilesContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFilesContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFilesContinueError)value, generator);
            }
        }
    }


    partial class LinkExpiry
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLinkExpiry(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LinkExpiry)value, generator);
            }
        }
    }


    partial class LinkAction
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLinkAction(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LinkAction)value, generator);
            }
        }
    }


    partial class MemberAccessLevelResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberAccessLevelResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberAccessLevelResult)value, generator, collapse);
            }
        }
    }


    partial class ListFilesResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFilesResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFilesResult)value, generator, collapse);
            }
        }
    }


    partial class FilePermission
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFilePermission(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FilePermission)value, generator, collapse);
            }
        }
    }


    partial class LinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((LinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class LinkPassword
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLinkPassword(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LinkPassword)value, generator);
            }
        }
    }


    partial class MemberAction
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMemberAction(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MemberAction)value, generator);
            }
        }
    }


    partial class FolderAction
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFolderAction(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FolderAction)value, generator);
            }
        }
    }


    partial class MemberPermission
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberPermission(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberPermission)value, generator, collapse);
            }
        }
    }


    partial class ListFolderMembersContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFolderMembersContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFolderMembersContinueError)value, generator);
            }
        }
    }


    partial class FolderLinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFolderLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FolderLinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class PathLinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePathLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PathLinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class MemberPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMemberPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MemberPolicy)value, generator);
            }
        }
    }


    partial class MountFolderError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMountFolderError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MountFolderError)value, generator);
            }
        }
    }


    partial class PendingUploadMode
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePendingUploadMode(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PendingUploadMode)value, generator);
            }
        }
    }


    partial class FolderPermission
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFolderPermission(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FolderPermission)value, generator, collapse);
            }
        }
    }


    partial class MemberSelector
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMemberSelector(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MemberSelector)value, generator);
            }
        }
    }


    partial class ListFoldersContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFoldersContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFoldersContinueError)value, generator);
            }
        }
    }


    partial class ParentFolderAccessInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeParentFolderAccessInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ParentFolderAccessInfo)value, generator, collapse);
            }
        }
    }


    partial class PermissionDeniedReason
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePermissionDeniedReason(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PermissionDeniedReason)value, generator);
            }
        }
    }


    partial class FolderPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFolderPolicy(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FolderPolicy)value, generator, collapse);
            }
        }
    }


    partial class ShareFolderJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeShareFolderJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ShareFolderJobStatus)value, generator);
            }
        }
    }


    partial class ShareFolderLaunch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeShareFolderLaunch(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ShareFolderLaunch)value, generator);
            }
        }
    }


    partial class RelinquishFileMembershipError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRelinquishFileMembershipError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RelinquishFileMembershipError)value, generator);
            }
        }
    }


    partial class ShareFolderError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeShareFolderError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ShareFolderError)value, generator);
            }
        }
    }


    partial class SharePathError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharePathError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharePathError)value, generator);
            }
        }
    }


    partial class ModifySharedLinkSettingsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeModifySharedLinkSettingsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ModifySharedLinkSettingsError)value, generator);
            }
        }
    }


    partial class SharedLinkSettingsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedLinkSettingsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedLinkSettingsError)value, generator);
            }
        }
    }


    partial class SharedContentLinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentLinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class SharingFileAccessError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharingFileAccessError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharingFileAccessError)value, generator);
            }
        }
    }


    partial class SharedLinkMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedLinkMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedLinkMetadata)value, generator, collapse);
            }
        }
    }


    partial class RelinquishFolderMembershipError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRelinquishFolderMembershipError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RelinquishFolderMembershipError)value, generator);
            }
        }
    }


    partial class SharedLinkPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedLinkPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedLinkPolicy)value, generator);
            }
        }
    }


    partial class SharingUserError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharingUserError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharingUserError)value, generator);
            }
        }
    }


    partial class SharedFileMembers
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFileMembers(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFileMembers)value, generator, collapse);
            }
        }
    }


    partial class SharedLinkSettings
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedLinkSettings(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedLinkSettings)value, generator, collapse);
            }
        }
    }


    partial class TeamMemberInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamMemberInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamMemberInfo)value, generator, collapse);
            }
        }
    }


    partial class UpdateFolderPolicyError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUpdateFolderPolicyError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UpdateFolderPolicyError)value, generator);
            }
        }
    }


    partial class UserInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserInfo)value, generator, collapse);
            }
        }
    }


    partial class RemoveFileMemberError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRemoveFileMemberError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RemoveFileMemberError)value, generator);
            }
        }
    }


    partial class SharedFileMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFileMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFileMetadata)value, generator, collapse);
            }
        }
    }


    partial class UserMembershipInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserMembershipInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserMembershipInfo)value, generator, collapse);
            }
        }
    }


    partial class ViewerInfoPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeViewerInfoPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ViewerInfoPolicy)value, generator);
            }
        }
    }


    partial class SharedFolderAccessError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedFolderAccessError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedFolderAccessError)value, generator);
            }
        }
    }


    partial class Visibility
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeVisibility(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((Visibility)value, generator);
            }
        }
    }


    partial class TransferFolderError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTransferFolderError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TransferFolderError)value, generator);
            }
        }
    }


    partial class SharedFolderMemberError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedFolderMemberError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedFolderMemberError)value, generator);
            }
        }
    }


    partial class RemoveFolderMemberError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRemoveFolderMemberError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RemoveFolderMemberError)value, generator);
            }
        }
    }


    partial class SharedFolderMembers
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderMembers(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderMembers)value, generator, collapse);
            }
        }
    }


    partial class RemoveMemberJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRemoveMemberJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RemoveMemberJobStatus)value, generator);
            }
        }
    }


    partial class SharedFolderMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderMetadata)value, generator, collapse);
            }
        }
    }


    partial class GetFileMetadataBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetFileMetadataBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetFileMetadataBatchResult)value, generator, collapse);
            }
        }
    }


    partial class UnmountFolderError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUnmountFolderError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UnmountFolderError)value, generator);
            }
        }
    }


    partial class UnshareFileError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUnshareFileError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UnshareFileError)value, generator);
            }
        }
    }


    partial class RequestedVisibility
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRequestedVisibility(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RequestedVisibility)value, generator);
            }
        }
    }


    partial class SharedLinkAccessFailureReason
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedLinkAccessFailureReason(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedLinkAccessFailureReason)value, generator);
            }
        }
    }


    partial class SharedLinkError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedLinkError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedLinkError)value, generator);
            }
        }
    }


    partial class UnshareFolderError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUnshareFolderError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UnshareFolderError)value, generator);
            }
        }
    }


    partial class ResolvedVisibility
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeResolvedVisibility(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ResolvedVisibility)value, generator);
            }
        }
    }


    partial class UpdateFolderMemberError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUpdateFolderMemberError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UpdateFolderMemberError)value, generator);
            }
        }
    }


    partial class RevokeSharedLinkError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRevokeSharedLinkError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RevokeSharedLinkError)value, generator);
            }
        }
    }


    partial class GetFileMetadataError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetFileMetadataError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetFileMetadataError)value, generator);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Fileproperties
{

    partial class AddPropertiesArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAddPropertiesArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AddPropertiesArg)value, generator, collapse);
            }
        }
    }


    partial class AddPropertiesError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAddPropertiesError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AddPropertiesError)value, generator);
            }
        }
    }


    partial class AddTemplateArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAddTemplateArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AddTemplateArg)value, generator, collapse);
            }
        }
    }


    partial class AddTemplateResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAddTemplateResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AddTemplateResult)value, generator, collapse);
            }
        }
    }


    partial class GetTemplateArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetTemplateArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetTemplateArg)value, generator, collapse);
            }
        }
    }


    partial class GetTemplateResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetTemplateResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetTemplateResult)value, generator, collapse);
            }
        }
    }


    partial class InvalidPropertyGroupError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeInvalidPropertyGroupError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((InvalidPropertyGroupError)value, generator);
            }
        }
    }


    partial class ListTemplateResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListTemplateResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListTemplateResult)value, generator, collapse);
            }
        }
    }


    partial class LogicalOperator
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLogicalOperator(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LogicalOperator)value, generator);
            }
        }
    }


    partial class LookUpPropertiesError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLookUpPropertiesError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LookUpPropertiesError)value, generator);
            }
        }
    }


    partial class LookupError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLookupError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LookupError)value, generator);
            }
        }
    }


    partial class ModifyTemplateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeModifyTemplateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ModifyTemplateError)value, generator);
            }
        }
    }


    partial class OverwritePropertyGroupArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeOverwritePropertyGroupArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((OverwritePropertyGroupArg)value, generator, collapse);
            }
        }
    }


    partial class PropertiesSearchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePropertiesSearchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PropertiesSearchError)value, generator);
            }
        }
    }


    partial class PropertiesSearchMatch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePropertiesSearchMatch(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PropertiesSearchMatch)value, generator, collapse);
            }
        }
    }


    partial class PropertiesSearchMode
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePropertiesSearchMode(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PropertiesSearchMode)value, generator);
            }
        }
    }


    partial class PropertiesSearchQuery
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePropertiesSearchQuery(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PropertiesSearchQuery)value, generator, collapse);
            }
        }
    }


    partial class PropertiesSearchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePropertiesSearchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PropertiesSearchResult)value, generator, collapse);
            }
        }
    }


    partial class PropertyField
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePropertyField(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PropertyField)value, generator, collapse);
            }
        }
    }


    partial class PropertyFieldTemplate
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePropertyFieldTemplate(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PropertyFieldTemplate)value, generator, collapse);
            }
        }
    }


    partial class PropertyGroup
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePropertyGroup(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PropertyGroup)value, generator, collapse);
            }
        }
    }


    partial class PropertyGroupUpdate
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePropertyGroupUpdate(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PropertyGroupUpdate)value, generator, collapse);
            }
        }
    }


    partial class PropertyType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePropertyType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PropertyType)value, generator);
            }
        }
    }


    partial class RemovePropertiesArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRemovePropertiesArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RemovePropertiesArg)value, generator, collapse);
            }
        }
    }


    partial class RemovePropertiesError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRemovePropertiesError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RemovePropertiesError)value, generator);
            }
        }
    }


    partial class TemplateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTemplateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TemplateError)value, generator);
            }
        }
    }


    partial class TemplateFilter
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTemplateFilter(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TemplateFilter)value, generator);
            }
        }
    }


    partial class UpdatePropertiesArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUpdatePropertiesArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UpdatePropertiesArg)value, generator, collapse);
            }
        }
    }


    partial class UpdatePropertiesError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUpdatePropertiesError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UpdatePropertiesError)value, generator);
            }
        }
    }


    partial class UpdateTemplateArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUpdateTemplateArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UpdateTemplateArg)value, generator, collapse);
            }
        }
    }


    partial class UpdateTemplateResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUpdateTemplateResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UpdateTemplateResult)value, generator, collapse);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Paper
{

    partial class AddMember
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAddMember(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AddMember)value, generator, collapse);
            }
        }
    }


    partial class AddPaperDocUserMemberResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAddPaperDocUserMemberResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AddPaperDocUserMemberResult)value, generator, collapse);
            }
        }
    }


    partial class AddPaperDocUserResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAddPaperDocUserResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AddPaperDocUserResult)value, generator);
            }
        }
    }


    partial class Cursor
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeCursor(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((Cursor)value, generator, collapse);
            }
        }
    }


    partial class DocLookupError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDocLookupError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DocLookupError)value, generator);
            }
        }
    }


    partial class ExportFormat
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeExportFormat(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ExportFormat)value, generator);
            }
        }
    }


    partial class Folder
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFolder(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((Folder)value, generator, collapse);
            }
        }
    }


    partial class FolderSharingPolicyType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFolderSharingPolicyType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FolderSharingPolicyType)value, generator);
            }
        }
    }


    partial class FoldersContainingPaperDoc
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFoldersContainingPaperDoc(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FoldersContainingPaperDoc)value, generator, collapse);
            }
        }
    }


    partial class ImportFormat
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeImportFormat(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ImportFormat)value, generator);
            }
        }
    }


    partial class InviteeInfoWithPermissionLevel
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeInviteeInfoWithPermissionLevel(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((InviteeInfoWithPermissionLevel)value, generator, collapse);
            }
        }
    }


    partial class ListDocsCursorError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListDocsCursorError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListDocsCursorError)value, generator);
            }
        }
    }


    partial class ListPaperDocsFilterBy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListPaperDocsFilterBy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListPaperDocsFilterBy)value, generator);
            }
        }
    }


    partial class ListPaperDocsResponse
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListPaperDocsResponse(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListPaperDocsResponse)value, generator, collapse);
            }
        }
    }


    partial class ListPaperDocsSortBy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListPaperDocsSortBy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListPaperDocsSortBy)value, generator);
            }
        }
    }


    partial class ListPaperDocsSortOrder
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListPaperDocsSortOrder(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListPaperDocsSortOrder)value, generator);
            }
        }
    }


    partial class ListUsersCursorError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListUsersCursorError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListUsersCursorError)value, generator);
            }
        }
    }


    partial class ListUsersOnFolderResponse
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListUsersOnFolderResponse(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListUsersOnFolderResponse)value, generator, collapse);
            }
        }
    }


    partial class ListUsersOnPaperDocResponse
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListUsersOnPaperDocResponse(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListUsersOnPaperDocResponse)value, generator, collapse);
            }
        }
    }


    partial class PaperApiCursorError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperApiCursorError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperApiCursorError)value, generator);
            }
        }
    }


    partial class PaperDocCreateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperDocCreateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperDocCreateError)value, generator);
            }
        }
    }


    partial class PaperDocCreateUpdateResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocCreateUpdateResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocCreateUpdateResult)value, generator, collapse);
            }
        }
    }


    partial class PaperDocExportResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocExportResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocExportResult)value, generator, collapse);
            }
        }
    }


    partial class PaperDocPermissionLevel
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperDocPermissionLevel(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperDocPermissionLevel)value, generator);
            }
        }
    }


    partial class PaperDocUpdateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperDocUpdateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperDocUpdateError)value, generator);
            }
        }
    }


    partial class PaperDocUpdatePolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperDocUpdatePolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperDocUpdatePolicy)value, generator);
            }
        }
    }


    partial class SharingTeamPolicyType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharingTeamPolicyType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharingTeamPolicyType)value, generator);
            }
        }
    }


    partial class SharingPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharingPolicy(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharingPolicy)value, generator, collapse);
            }
        }
    }


    partial class UserInfoWithPermissionLevel
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserInfoWithPermissionLevel(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserInfoWithPermissionLevel)value, generator, collapse);
            }
        }
    }


    partial class SharingPublicPolicyType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharingPublicPolicyType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharingPublicPolicyType)value, generator);
            }
        }
    }


    partial class UserOnPaperDocFilter
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUserOnPaperDocFilter(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UserOnPaperDocFilter)value, generator);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Teamlog
{

    partial class DeviceUnlinkPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeviceUnlinkPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeviceUnlinkPolicy)value, generator);
            }
        }
    }


    partial class AccessMethodLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAccessMethodLogInfo(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AccessMethodLogInfo)value, generator);
            }
        }
    }


    partial class DisabledDomainInvitesDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDisabledDomainInvitesDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DisabledDomainInvitesDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainInvitesApproveRequestToJoinTeamDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainInvitesApproveRequestToJoinTeamDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainInvitesApproveRequestToJoinTeamDetails)value, generator, collapse);
            }
        }
    }


    partial class AccountCaptureAvailability
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAccountCaptureAvailability(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AccountCaptureAvailability)value, generator);
            }
        }
    }


    partial class FileRequestAddDeadlineDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestAddDeadlineDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestAddDeadlineDetails)value, generator, collapse);
            }
        }
    }


    partial class AccountCaptureChangeAvailabilityDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAccountCaptureChangeAvailabilityDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AccountCaptureChangeAvailabilityDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainInvitesDeclineRequestToJoinTeamDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainInvitesDeclineRequestToJoinTeamDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainInvitesDeclineRequestToJoinTeamDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestChangeFolderDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestChangeFolderDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestChangeFolderDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainInvitesEmailExistingUsersDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainInvitesEmailExistingUsersDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainInvitesEmailExistingUsersDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestChangeTitleDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestChangeTitleDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestChangeTitleDetails)value, generator, collapse);
            }
        }
    }


    partial class AccountCaptureChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAccountCaptureChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AccountCaptureChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainInvitesRequestToJoinTeamDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainInvitesRequestToJoinTeamDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainInvitesRequestToJoinTeamDetails)value, generator, collapse);
            }
        }
    }


    partial class AccountCaptureMigrateAccountDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAccountCaptureMigrateAccountDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AccountCaptureMigrateAccountDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainInvitesSetInviteNewUserPrefToNoDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainInvitesSetInviteNewUserPrefToNoDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainInvitesSetInviteNewUserPrefToNoDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestCloseDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestCloseDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestCloseDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainInvitesSetInviteNewUserPrefToYesDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainInvitesSetInviteNewUserPrefToYesDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainInvitesSetInviteNewUserPrefToYesDetails)value, generator, collapse);
            }
        }
    }


    partial class AccountCapturePolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAccountCapturePolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AccountCapturePolicy)value, generator);
            }
        }
    }


    partial class FileRequestCreateDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestCreateDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestCreateDetails)value, generator, collapse);
            }
        }
    }


    partial class AccountCaptureRelinquishAccountDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAccountCaptureRelinquishAccountDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AccountCaptureRelinquishAccountDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainVerificationAddDomainFailDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainVerificationAddDomainFailDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainVerificationAddDomainFailDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainVerificationAddDomainSuccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainVerificationAddDomainSuccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainVerificationAddDomainSuccessDetails)value, generator, collapse);
            }
        }
    }


    partial class ActorLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeActorLogInfo(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ActorLogInfo)value, generator);
            }
        }
    }


    partial class FileRequestReceiveFileDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestReceiveFileDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestReceiveFileDetails)value, generator, collapse);
            }
        }
    }


    partial class DomainVerificationRemoveDomainDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDomainVerificationRemoveDomainDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DomainVerificationRemoveDomainDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestRemoveDeadlineDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestRemoveDeadlineDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestRemoveDeadlineDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestSendDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestSendDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestSendDetails)value, generator, collapse);
            }
        }
    }


    partial class AdminRole
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAdminRole(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AdminRole)value, generator);
            }
        }
    }


    partial class DurationLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDurationLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DurationLogInfo)value, generator, collapse);
            }
        }
    }


    partial class AllowDownloadDisabledDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAllowDownloadDisabledDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AllowDownloadDisabledDetails)value, generator, collapse);
            }
        }
    }


    partial class EmmAddExceptionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEmmAddExceptionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EmmAddExceptionDetails)value, generator, collapse);
            }
        }
    }


    partial class AllowDownloadEnabledDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAllowDownloadEnabledDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AllowDownloadEnabledDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestsChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestsChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestsChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class EmmChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEmmChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EmmChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestsEmailsEnabledDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestsEmailsEnabledDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestsEmailsEnabledDetails)value, generator, collapse);
            }
        }
    }


    partial class ApiSessionLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeApiSessionLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ApiSessionLogInfo)value, generator, collapse);
            }
        }
    }


    partial class EmmCreateExceptionsReportDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEmmCreateExceptionsReportDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EmmCreateExceptionsReportDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestsEmailsRestrictedToTeamOnlyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestsEmailsRestrictedToTeamOnlyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestsEmailsRestrictedToTeamOnlyDetails)value, generator, collapse);
            }
        }
    }


    partial class AppLinkTeamDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAppLinkTeamDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AppLinkTeamDetails)value, generator, collapse);
            }
        }
    }


    partial class EmmCreateUsageReportDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEmmCreateUsageReportDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EmmCreateUsageReportDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRequestsPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFileRequestsPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FileRequestsPolicy)value, generator);
            }
        }
    }


    partial class AppLinkUserDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAppLinkUserDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AppLinkUserDetails)value, generator, collapse);
            }
        }
    }


    partial class FileResolveCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileResolveCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileResolveCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class AppLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAppLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AppLogInfo)value, generator, collapse);
            }
        }
    }


    partial class EmmLoginSuccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEmmLoginSuccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EmmLoginSuccessDetails)value, generator, collapse);
            }
        }
    }


    partial class AppUnlinkTeamDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAppUnlinkTeamDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AppUnlinkTeamDetails)value, generator, collapse);
            }
        }
    }


    partial class EmmRefreshAuthTokenDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEmmRefreshAuthTokenDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EmmRefreshAuthTokenDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRestoreDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRestoreDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRestoreDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRevertDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRevertDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRevertDetails)value, generator, collapse);
            }
        }
    }


    partial class AppUnlinkUserDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeAppUnlinkUserDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((AppUnlinkUserDetails)value, generator, collapse);
            }
        }
    }


    partial class EmmRemoveExceptionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEmmRemoveExceptionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EmmRemoveExceptionDetails)value, generator, collapse);
            }
        }
    }


    partial class FileRollbackChangesDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRollbackChangesDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRollbackChangesDetails)value, generator, collapse);
            }
        }
    }


    partial class EnabledDomainInvitesDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeEnabledDomainInvitesDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((EnabledDomainInvitesDetails)value, generator, collapse);
            }
        }
    }


    partial class AssetLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAssetLogInfo(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AssetLogInfo)value, generator);
            }
        }
    }


    partial class EventCategory
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeEventCategory(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((EventCategory)value, generator);
            }
        }
    }


    partial class Certificate
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeCertificate(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((Certificate)value, generator, collapse);
            }
        }
    }


    partial class CollectionShareDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeCollectionShareDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((CollectionShareDetails)value, generator, collapse);
            }
        }
    }


    partial class FileSaveCopyReferenceDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileSaveCopyReferenceDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileSaveCopyReferenceDetails)value, generator, collapse);
            }
        }
    }


    partial class Confidentiality
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeConfidentiality(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((Confidentiality)value, generator);
            }
        }
    }


    partial class FileUnlikeCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileUnlikeCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileUnlikeCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class ContentPermanentDeletePolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeContentPermanentDeletePolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ContentPermanentDeletePolicy)value, generator);
            }
        }
    }


    partial class FileUnresolveCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileUnresolveCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileUnresolveCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class ContextLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeContextLogInfo(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ContextLogInfo)value, generator);
            }
        }
    }


    partial class FolderLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFolderLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FolderLogInfo)value, generator, collapse);
            }
        }
    }


    partial class CreateFolderDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeCreateFolderDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((CreateFolderDetails)value, generator, collapse);
            }
        }
    }


    partial class DataPlacementRestrictionChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDataPlacementRestrictionChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DataPlacementRestrictionChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class GeoLocationLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGeoLocationLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GeoLocationLogInfo)value, generator, collapse);
            }
        }
    }


    partial class DataPlacementRestrictionSatisfyPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDataPlacementRestrictionSatisfyPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DataPlacementRestrictionSatisfyPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class GetTeamEventsContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetTeamEventsContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetTeamEventsContinueError)value, generator);
            }
        }
    }


    partial class DesktopSessionLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDesktopSessionLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DesktopSessionLogInfo)value, generator, collapse);
            }
        }
    }


    partial class GetTeamEventsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetTeamEventsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetTeamEventsError)value, generator);
            }
        }
    }


    partial class DeviceApprovalsChangeDesktopPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceApprovalsChangeDesktopPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceApprovalsChangeDesktopPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class GetTeamEventsResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetTeamEventsResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetTeamEventsResult)value, generator, collapse);
            }
        }
    }


    partial class GoogleSsoChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGoogleSsoChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GoogleSsoChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceApprovalsChangeMobilePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceApprovalsChangeMobilePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceApprovalsChangeMobilePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class GoogleSsoPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGoogleSsoPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GoogleSsoPolicy)value, generator);
            }
        }
    }


    partial class GroupAddExternalIdDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupAddExternalIdDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupAddExternalIdDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceApprovalsChangeOverageActionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceApprovalsChangeOverageActionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceApprovalsChangeOverageActionDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupAddMemberDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupAddMemberDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupAddMemberDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupChangeExternalIdDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupChangeExternalIdDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupChangeExternalIdDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceApprovalsChangeUnlinkActionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceApprovalsChangeUnlinkActionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceApprovalsChangeUnlinkActionDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupChangeManagementTypeDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupChangeManagementTypeDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupChangeManagementTypeDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceApprovalsPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeviceApprovalsPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeviceApprovalsPolicy)value, generator);
            }
        }
    }


    partial class GroupChangeMemberRoleDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupChangeMemberRoleDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupChangeMemberRoleDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceChangeIpDesktopDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceChangeIpDesktopDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceChangeIpDesktopDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupCreateDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupCreateDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupCreateDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceChangeIpMobileDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceChangeIpMobileDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceChangeIpMobileDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupDeleteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupDeleteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupDeleteDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceChangeIpWebDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceChangeIpWebDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceChangeIpWebDetails)value, generator, collapse);
            }
        }
    }


    partial class JoinTeamDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeJoinTeamDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((JoinTeamDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupJoinPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupJoinPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupJoinPolicy)value, generator);
            }
        }
    }


    partial class DeviceDeleteOnUnlinkFailDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceDeleteOnUnlinkFailDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceDeleteOnUnlinkFailDetails)value, generator, collapse);
            }
        }
    }


    partial class LinkAudience
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLinkAudience(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LinkAudience)value, generator);
            }
        }
    }


    partial class DeviceDeleteOnUnlinkSuccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceDeleteOnUnlinkSuccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceDeleteOnUnlinkSuccessDetails)value, generator, collapse);
            }
        }
    }


    partial class LogoutDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeLogoutDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((LogoutDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupLogInfo)value, generator, collapse);
            }
        }
    }


    partial class DeviceLinkFailDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceLinkFailDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceLinkFailDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberAddNameDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberAddNameDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberAddNameDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupMovedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupMovedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupMovedDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceLinkSuccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceLinkSuccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceLinkSuccessDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupRemoveExternalIdDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupRemoveExternalIdDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupRemoveExternalIdDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberChangeAdminRoleDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberChangeAdminRoleDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberChangeAdminRoleDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupRemoveMemberDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupRemoveMemberDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupRemoveMemberDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberChangeEmailDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberChangeEmailDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberChangeEmailDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupRenameDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupRenameDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupRenameDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberChangeMembershipTypeDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberChangeMembershipTypeDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberChangeMembershipTypeDetails)value, generator, collapse);
            }
        }
    }


    partial class GroupUserManagementChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupUserManagementChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupUserManagementChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceLogInfo)value, generator, collapse);
            }
        }
    }


    partial class GroupUserManagementPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupUserManagementPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupUserManagementPolicy)value, generator);
            }
        }
    }


    partial class MemberChangeNameDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberChangeNameDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberChangeNameDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceManagementDisabledDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceManagementDisabledDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceManagementDisabledDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceManagementEnabledDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceManagementEnabledDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceManagementEnabledDetails)value, generator, collapse);
            }
        }
    }


    partial class HostLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeHostLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((HostLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PaperContentPermanentlyDeleteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentPermanentlyDeleteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentPermanentlyDeleteDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeviceType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeviceType)value, generator);
            }
        }
    }


    partial class MemberChangeStatusDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberChangeStatusDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberChangeStatusDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberSpaceLimitsRemoveExceptionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberSpaceLimitsRemoveExceptionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberSpaceLimitsRemoveExceptionDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperContentRemoveFromFolderDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentRemoveFromFolderDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentRemoveFromFolderDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberPermanentlyDeleteAccountContentsDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberPermanentlyDeleteAccountContentsDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberPermanentlyDeleteAccountContentsDetails)value, generator, collapse);
            }
        }
    }


    partial class DeviceUnlinkDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceUnlinkDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceUnlinkDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMemberStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MemberStatus)value, generator);
            }
        }
    }


    partial class PaperContentRemoveMemberDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentRemoveMemberDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentRemoveMemberDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberRequestsChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberRequestsChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberRequestsChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class FileCommentsPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFileCommentsPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FileCommentsPolicy)value, generator);
            }
        }
    }


    partial class MemberSuggestDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberSuggestDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberSuggestDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperContentRenameDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentRenameDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentRenameDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberRequestsPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMemberRequestsPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MemberRequestsPolicy)value, generator);
            }
        }
    }


    partial class MemberSuggestionsChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberSuggestionsChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberSuggestionsChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class FileCopyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileCopyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileCopyDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperContentRestoreDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentRestoreDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentRestoreDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberSpaceLimitsAddExceptionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberSpaceLimitsAddExceptionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberSpaceLimitsAddExceptionDetails)value, generator, collapse);
            }
        }
    }


    partial class FileDeleteCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileDeleteCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileDeleteCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberSpaceLimitsChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberSpaceLimitsChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberSpaceLimitsChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberSuggestionsPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMemberSuggestionsPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MemberSuggestionsPolicy)value, generator);
            }
        }
    }


    partial class PaperDocAddCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocAddCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocAddCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class FileDeleteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileDeleteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileDeleteDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberSpaceLimitsChangeStatusDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberSpaceLimitsChangeStatusDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberSpaceLimitsChangeStatusDetails)value, generator, collapse);
            }
        }
    }


    partial class MemberTransferAccountContentsDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberTransferAccountContentsDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberTransferAccountContentsDetails)value, generator, collapse);
            }
        }
    }


    partial class FileDownloadDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileDownloadDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileDownloadDetails)value, generator, collapse);
            }
        }
    }


    partial class NoteAclTeamLinkDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNoteAclTeamLinkDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NoteAclTeamLinkDetails)value, generator, collapse);
            }
        }
    }


    partial class MicrosoftOfficeAddinChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMicrosoftOfficeAddinChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MicrosoftOfficeAddinChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocChangeMemberRoleDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocChangeMemberRoleDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocChangeMemberRoleDetails)value, generator, collapse);
            }
        }
    }


    partial class NoteShareReceiveDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNoteShareReceiveDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NoteShareReceiveDetails)value, generator, collapse);
            }
        }
    }


    partial class MicrosoftOfficeAddinPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMicrosoftOfficeAddinPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MicrosoftOfficeAddinPolicy)value, generator);
            }
        }
    }


    partial class NoteSharedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNoteSharedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NoteSharedDetails)value, generator, collapse);
            }
        }
    }


    partial class FileEditDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileEditDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileEditDetails)value, generator, collapse);
            }
        }
    }


    partial class MissingDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMissingDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MissingDetails)value, generator, collapse);
            }
        }
    }


    partial class FileGetCopyReferenceDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileGetCopyReferenceDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileGetCopyReferenceDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocChangeSharingPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocChangeSharingPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocChangeSharingPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class MobileSessionLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMobileSessionLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MobileSessionLogInfo)value, generator, collapse);
            }
        }
    }


    partial class OpenNoteSharedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeOpenNoteSharedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((OpenNoteSharedDetails)value, generator, collapse);
            }
        }
    }


    partial class FileLikeCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileLikeCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileLikeCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class PermanentDeleteChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePermanentDeleteChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PermanentDeleteChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class FileLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PaperDocChangeSubscriptionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocChangeSubscriptionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocChangeSubscriptionDetails)value, generator, collapse);
            }
        }
    }


    partial class OriginLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeOriginLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((OriginLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PlacementRestriction
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePlacementRestriction(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PlacementRestriction)value, generator);
            }
        }
    }


    partial class NamespaceRelativePathLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNamespaceRelativePathLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NamespaceRelativePathLogInfo)value, generator, collapse);
            }
        }
    }


    partial class FileMoveDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileMoveDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileMoveDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocDeleteCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocDeleteCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocDeleteCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class RelocateAssetReferencesLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRelocateAssetReferencesLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RelocateAssetReferencesLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PaperDocDeletedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocDeletedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocDeletedDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperAccessType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperAccessType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperAccessType)value, generator);
            }
        }
    }


    partial class NetworkControlChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNetworkControlChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NetworkControlChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocDownloadDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocDownloadDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocDownloadDetails)value, generator, collapse);
            }
        }
    }


    partial class NetworkControlPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeNetworkControlPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((NetworkControlPolicy)value, generator);
            }
        }
    }


    partial class FilePermanentlyDeleteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFilePermanentlyDeleteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FilePermanentlyDeleteDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperAdminExportStartDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperAdminExportStartDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperAdminExportStartDetails)value, generator, collapse);
            }
        }
    }


    partial class ResellerLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeResellerLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ResellerLogInfo)value, generator, collapse);
            }
        }
    }


    partial class FilePreviewDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFilePreviewDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FilePreviewDetails)value, generator, collapse);
            }
        }
    }


    partial class ResellerSupportSessionEndDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeResellerSupportSessionEndDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ResellerSupportSessionEndDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperChangeDeploymentPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperChangeDeploymentPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperChangeDeploymentPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class NonTeamMemberLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNonTeamMemberLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NonTeamMemberLogInfo)value, generator, collapse);
            }
        }
    }


    partial class FileRenameDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRenameDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRenameDetails)value, generator, collapse);
            }
        }
    }


    partial class ResellerSupportSessionStartDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeResellerSupportSessionStartDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ResellerSupportSessionStartDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperChangeMemberPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperChangeMemberPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperChangeMemberPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class NoteAclInviteOnlyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNoteAclInviteOnlyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NoteAclInviteOnlyDetails)value, generator, collapse);
            }
        }
    }


    partial class NoteAclLinkDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNoteAclLinkDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NoteAclLinkDetails)value, generator, collapse);
            }
        }
    }


    partial class SessionLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSessionLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SessionLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PaperChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocMentionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocMentionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocMentionDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocEditCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocEditCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocEditCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocEditDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocEditDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocEditDetails)value, generator, collapse);
            }
        }
    }


    partial class SfAddGroupDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfAddGroupDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfAddGroupDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocRequestAccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocRequestAccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocRequestAccessDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocFollowedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocFollowedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocFollowedDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperExternalViewForbidDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperExternalViewForbidDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperExternalViewForbidDetails)value, generator, collapse);
            }
        }
    }


    partial class SfAllowNonMembersToViewSharedLinksDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfAllowNonMembersToViewSharedLinksDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfAllowNonMembersToViewSharedLinksDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocResolveCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocResolveCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocResolveCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperContentAddMemberDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentAddMemberDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentAddMemberDetails)value, generator, collapse);
            }
        }
    }


    partial class SfTeamInviteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfTeamInviteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfTeamInviteDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperFolderChangeSubscriptionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperFolderChangeSubscriptionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperFolderChangeSubscriptionDetails)value, generator, collapse);
            }
        }
    }


    partial class SfExternalInviteWarnDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfExternalInviteWarnDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfExternalInviteWarnDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperContentAddToFolderDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentAddToFolderDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentAddToFolderDetails)value, generator, collapse);
            }
        }
    }


    partial class EventDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeEventDetails(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((EventDetails)value, generator);
            }
        }
    }


    partial class SfTeamJoinDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfTeamJoinDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfTeamJoinDetails)value, generator, collapse);
            }
        }
    }


    partial class SfInviteGroupDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfInviteGroupDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfInviteGroupDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperFolderDeletedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperFolderDeletedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperFolderDeletedDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocRevertDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocRevertDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocRevertDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperContentArchiveDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentArchiveDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentArchiveDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperFolderFollowedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperFolderFollowedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperFolderFollowedDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocSlackShareDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocSlackShareDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocSlackShareDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperContentCreateDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperContentCreateDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperContentCreateDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperFolderLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperFolderLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperFolderLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PaperDocTeamInviteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocTeamInviteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocTeamInviteDetails)value, generator, collapse);
            }
        }
    }


    partial class SfNestDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfNestDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfNestDetails)value, generator, collapse);
            }
        }
    }


    partial class SfTeamJoinFromOobLinkDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfTeamJoinFromOobLinkDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfTeamJoinFromOobLinkDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperFolderTeamInviteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperFolderTeamInviteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperFolderTeamInviteDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentCopyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentCopyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentCopyDetails)value, generator, collapse);
            }
        }
    }


    partial class SfTeamDeclineDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfTeamDeclineDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfTeamDeclineDetails)value, generator, collapse);
            }
        }
    }


    partial class SfTeamUninviteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfTeamUninviteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfTeamUninviteDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperMemberPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperMemberPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperMemberPolicy)value, generator);
            }
        }
    }


    partial class SharedContentDownloadDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentDownloadDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentDownloadDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocTrashedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocTrashedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocTrashedDetails)value, generator, collapse);
            }
        }
    }


    partial class ParticipantLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeParticipantLogInfo(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ParticipantLogInfo)value, generator);
            }
        }
    }


    partial class SharedContentDownloadsPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedContentDownloadsPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedContentDownloadsPolicy)value, generator);
            }
        }
    }


    partial class SfTeamGrantAccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfTeamGrantAccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfTeamGrantAccessDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocUnresolveCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocUnresolveCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocUnresolveCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentRelinquishMembershipDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentRelinquishMembershipDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentRelinquishMembershipDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocUntrashedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocUntrashedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocUntrashedDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentAddInviteesDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentAddInviteesDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentAddInviteesDetails)value, generator, collapse);
            }
        }
    }


    partial class PasswordChangeDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePasswordChangeDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PasswordChangeDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentRemoveInviteeDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentRemoveInviteeDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentRemoveInviteeDetails)value, generator, collapse);
            }
        }
    }


    partial class SfTeamInviteChangeRoleDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSfTeamInviteChangeRoleDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SfTeamInviteChangeRoleDetails)value, generator, collapse);
            }
        }
    }


    partial class PasswordLoginFailDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePasswordLoginFailDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PasswordLoginFailDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentAddLinkExpiryDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentAddLinkExpiryDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentAddLinkExpiryDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentRemoveLinkExpiryDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentRemoveLinkExpiryDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentRemoveLinkExpiryDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocViewDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocViewDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocViewDetails)value, generator, collapse);
            }
        }
    }


    partial class PasswordLoginSuccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePasswordLoginSuccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PasswordLoginSuccessDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDocumentLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperDocumentLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperDocumentLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PasswordResetAllDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePasswordResetAllDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PasswordResetAllDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderChangeMemberManagementPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderChangeMemberManagementPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderChangeMemberManagementPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentRemoveLinkPasswordDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentRemoveLinkPasswordDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentRemoveLinkPasswordDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperDownloadFormat
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperDownloadFormat(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperDownloadFormat)value, generator);
            }
        }
    }


    partial class SharedContentAddLinkPasswordDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentAddLinkPasswordDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentAddLinkPasswordDetails)value, generator, collapse);
            }
        }
    }


    partial class PasswordResetDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePasswordResetDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PasswordResetDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperEnabledUsersGroupAdditionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperEnabledUsersGroupAdditionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperEnabledUsersGroupAdditionDetails)value, generator, collapse);
            }
        }
    }


    partial class PathLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePathLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PathLogInfo)value, generator, collapse);
            }
        }
    }


    partial class PaperEnabledUsersGroupRemovalDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperEnabledUsersGroupRemovalDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperEnabledUsersGroupRemovalDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderChangeMemberPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderChangeMemberPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderChangeMemberPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperExternalViewAllowDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperExternalViewAllowDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperExternalViewAllowDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentAddMemberDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentAddMemberDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentAddMemberDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentRemoveMemberDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentRemoveMemberDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentRemoveMemberDetails)value, generator, collapse);
            }
        }
    }


    partial class PaperExternalViewDefaultTeamDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePaperExternalViewDefaultTeamDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PaperExternalViewDefaultTeamDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelAppCreateDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelAppCreateDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelAppCreateDetails)value, generator, collapse);
            }
        }
    }


    partial class SmartSyncChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSmartSyncChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SmartSyncChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderCreateDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderCreateDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderCreateDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentChangeDownloadsPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentChangeDownloadsPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentChangeDownloadsPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelCreateDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelCreateDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelCreateDetails)value, generator, collapse);
            }
        }
    }


    partial class SmartSyncCreateAdminPrivilegeReportDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSmartSyncCreateAdminPrivilegeReportDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SmartSyncCreateAdminPrivilegeReportDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderLinkPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedFolderLinkPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedFolderLinkPolicy)value, generator);
            }
        }
    }


    partial class SharedContentChangeInviteeRoleDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentChangeInviteeRoleDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentChangeInviteeRoleDetails)value, generator, collapse);
            }
        }
    }


    partial class SmartSyncNotOptOutDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSmartSyncNotOptOutDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SmartSyncNotOptOutDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelDisableDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelDisableDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelDisableDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderMemberPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedFolderMemberPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedFolderMemberPolicy)value, generator);
            }
        }
    }


    partial class SmartSyncOptOutDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSmartSyncOptOutDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SmartSyncOptOutDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderMembershipManagementPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedFolderMembershipManagementPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedFolderMembershipManagementPolicy)value, generator);
            }
        }
    }


    partial class SharedContentRequestAccessDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentRequestAccessDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentRequestAccessDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentChangeLinkAudienceDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentChangeLinkAudienceDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentChangeLinkAudienceDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelFbShareDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelFbShareDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelFbShareDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderMountDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderMountDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderMountDetails)value, generator, collapse);
            }
        }
    }


    partial class SmartSyncOptOutPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSmartSyncOptOutPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SmartSyncOptOutPolicy)value, generator);
            }
        }
    }


    partial class ShmodelGroupShareDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelGroupShareDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelGroupShareDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentUnshareDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentUnshareDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentUnshareDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderTransferOwnershipDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderTransferOwnershipDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderTransferOwnershipDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelRemoveExpirationDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelRemoveExpirationDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelRemoveExpirationDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentChangeLinkExpiryDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentChangeLinkExpiryDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentChangeLinkExpiryDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderUnmountDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderUnmountDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderUnmountDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelSetExpirationDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelSetExpirationDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelSetExpirationDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelTeamCopyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelTeamCopyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelTeamCopyDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentChangeLinkPasswordDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentChangeLinkPasswordDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentChangeLinkPasswordDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedNoteOpenedDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedNoteOpenedDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedNoteOpenedDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelTeamDownloadDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelTeamDownloadDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelTeamDownloadDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedContentViewDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentViewDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentViewDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelTeamShareDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelTeamShareDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelTeamShareDetails)value, generator, collapse);
            }
        }
    }


    partial class SharingChangeFolderJoinPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharingChangeFolderJoinPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharingChangeFolderJoinPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelTeamViewDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelTeamViewDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelTeamViewDetails)value, generator, collapse);
            }
        }
    }


    partial class SmartSyncPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSmartSyncPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SmartSyncPolicy)value, generator);
            }
        }
    }


    partial class SharedContentChangeMemberRoleDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentChangeMemberRoleDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentChangeMemberRoleDetails)value, generator, collapse);
            }
        }
    }


    partial class SharingChangeLinkPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharingChangeLinkPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharingChangeLinkPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelVisibilityPasswordDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelVisibilityPasswordDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelVisibilityPasswordDetails)value, generator, collapse);
            }
        }
    }


    partial class SpaceLimitsLevel
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSpaceLimitsLevel(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SpaceLimitsLevel)value, generator);
            }
        }
    }


    partial class SharingChangeMemberPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharingChangeMemberPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharingChangeMemberPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelVisibilityPublicDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelVisibilityPublicDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelVisibilityPublicDetails)value, generator, collapse);
            }
        }
    }


    partial class ShmodelVisibilityTeamOnlyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeShmodelVisibilityTeamOnlyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ShmodelVisibilityTeamOnlyDetails)value, generator, collapse);
            }
        }
    }


    partial class SharingFolderJoinPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharingFolderJoinPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharingFolderJoinPolicy)value, generator);
            }
        }
    }


    partial class SharedContentViewerInfoPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedContentViewerInfoPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedContentViewerInfoPolicy)value, generator);
            }
        }
    }


    partial class SharedContentChangeViewerInfoPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentChangeViewerInfoPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentChangeViewerInfoPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class SignInAsSessionEndDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSignInAsSessionEndDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SignInAsSessionEndDetails)value, generator, collapse);
            }
        }
    }


    partial class SharingLinkPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharingLinkPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharingLinkPolicy)value, generator);
            }
        }
    }


    partial class SharedFolderChangeConfidentialityDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderChangeConfidentialityDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderChangeConfidentialityDetails)value, generator, collapse);
            }
        }
    }


    partial class SignInAsSessionStartDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSignInAsSessionStartDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SignInAsSessionStartDetails)value, generator, collapse);
            }
        }
    }


    partial class SharingMemberPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharingMemberPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharingMemberPolicy)value, generator);
            }
        }
    }


    partial class SpaceLimitsStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSpaceLimitsStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SpaceLimitsStatus)value, generator);
            }
        }
    }


    partial class SharedContentClaimInvitationDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedContentClaimInvitationDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedContentClaimInvitationDetails)value, generator, collapse);
            }
        }
    }


    partial class TfaResetDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaResetDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaResetDetails)value, generator, collapse);
            }
        }
    }


    partial class SsoAddLoginUrlDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoAddLoginUrlDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoAddLoginUrlDetails)value, generator, collapse);
            }
        }
    }


    partial class SsoChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamMergeFromDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamMergeFromDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamMergeFromDetails)value, generator, collapse);
            }
        }
    }


    partial class SharedFolderChangeLinkPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSharedFolderChangeLinkPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SharedFolderChangeLinkPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class SsoAddLogoutUrlDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoAddLogoutUrlDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoAddLogoutUrlDetails)value, generator, collapse);
            }
        }
    }


    partial class SsoChangeSamlIdentityModeDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoChangeSamlIdentityModeDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoChangeSamlIdentityModeDetails)value, generator, collapse);
            }
        }
    }


    partial class TimeUnit
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTimeUnit(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TimeUnit)value, generator);
            }
        }
    }


    partial class TeamMergeToDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamMergeToDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamMergeToDetails)value, generator, collapse);
            }
        }
    }


    partial class SsoLoginFailDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoLoginFailDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoLoginFailDetails)value, generator, collapse);
            }
        }
    }


    partial class TwoAccountChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTwoAccountChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TwoAccountChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class SsoChangeCertDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoChangeCertDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoChangeCertDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamName
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamName(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamName)value, generator, collapse);
            }
        }
    }


    partial class TwoAccountPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTwoAccountPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TwoAccountPolicy)value, generator);
            }
        }
    }


    partial class SsoChangeLoginUrlDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoChangeLoginUrlDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoChangeLoginUrlDetails)value, generator, collapse);
            }
        }
    }


    partial class UserLinkedAppLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserLinkedAppLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserLinkedAppLogInfo)value, generator, collapse);
            }
        }
    }


    partial class SsoChangeLogoutUrlDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoChangeLogoutUrlDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoChangeLogoutUrlDetails)value, generator, collapse);
            }
        }
    }


    partial class SsoRemoveLoginUrlDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoRemoveLoginUrlDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoRemoveLoginUrlDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamProfileAddLogoDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamProfileAddLogoDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamProfileAddLogoDetails)value, generator, collapse);
            }
        }
    }


    partial class UserLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserLogInfo)value, generator, collapse);
            }
        }
    }


    partial class SsoRemoveLogoutUrlDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSsoRemoveLogoutUrlDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SsoRemoveLogoutUrlDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamProfileChangeLogoDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamProfileChangeLogoDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamProfileChangeLogoDetails)value, generator, collapse);
            }
        }
    }


    partial class UserNameLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserNameLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserNameLogInfo)value, generator, collapse);
            }
        }
    }


    partial class TeamActivityCreateReportDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamActivityCreateReportDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamActivityCreateReportDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamProfileChangeNameDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamProfileChangeNameDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamProfileChangeNameDetails)value, generator, collapse);
            }
        }
    }


    partial class UserOrTeamLinkedAppLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserOrTeamLinkedAppLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserOrTeamLinkedAppLogInfo)value, generator, collapse);
            }
        }
    }


    partial class TeamProfileRemoveLogoDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamProfileRemoveLogoDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamProfileRemoveLogoDetails)value, generator, collapse);
            }
        }
    }


    partial class WebSessionLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeWebSessionLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((WebSessionLogInfo)value, generator, collapse);
            }
        }
    }


    partial class TfaAddBackupPhoneDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaAddBackupPhoneDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaAddBackupPhoneDetails)value, generator, collapse);
            }
        }
    }


    partial class EventType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeEventType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((EventType)value, generator);
            }
        }
    }


    partial class TfaAddSecurityKeyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaAddSecurityKeyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaAddSecurityKeyDetails)value, generator, collapse);
            }
        }
    }


    partial class WebSessionsChangeFixedLengthPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeWebSessionsChangeFixedLengthPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((WebSessionsChangeFixedLengthPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class ExtendedVersionHistoryChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeExtendedVersionHistoryChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ExtendedVersionHistoryChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class TfaChangeBackupPhoneDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaChangeBackupPhoneDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaChangeBackupPhoneDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamEvent
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamEvent(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamEvent)value, generator, collapse);
            }
        }
    }


    partial class ExtendedVersionHistoryPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeExtendedVersionHistoryPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ExtendedVersionHistoryPolicy)value, generator);
            }
        }
    }


    partial class WebSessionsChangeIdleLengthPolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeWebSessionsChangeIdleLengthPolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((WebSessionsChangeIdleLengthPolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class TfaChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaChangePolicyDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderChangeStatusDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderChangeStatusDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderChangeStatusDetails)value, generator, collapse);
            }
        }
    }


    partial class WebSessionsFixedLengthPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeWebSessionsFixedLengthPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((WebSessionsFixedLengthPolicy)value, generator);
            }
        }
    }


    partial class TeamFolderCreateDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderCreateDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderCreateDetails)value, generator, collapse);
            }
        }
    }


    partial class FailureDetailsLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFailureDetailsLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FailureDetailsLogInfo)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderDowngradeDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderDowngradeDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderDowngradeDetails)value, generator, collapse);
            }
        }
    }


    partial class WebSessionsIdleLengthPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeWebSessionsIdleLengthPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((WebSessionsIdleLengthPolicy)value, generator);
            }
        }
    }


    partial class FileAddCommentDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileAddCommentDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileAddCommentDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderPermanentlyDeleteDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderPermanentlyDeleteDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderPermanentlyDeleteDetails)value, generator, collapse);
            }
        }
    }


    partial class FileAddDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileAddDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileAddDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderRenameDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderRenameDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderRenameDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderStatus)value, generator);
            }
        }
    }


    partial class TfaChangeStatusDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaChangeStatusDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaChangeStatusDetails)value, generator, collapse);
            }
        }
    }


    partial class TeamLinkedAppLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamLinkedAppLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamLinkedAppLogInfo)value, generator, collapse);
            }
        }
    }


    partial class FileChangeCommentSubscriptionDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileChangeCommentSubscriptionDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileChangeCommentSubscriptionDetails)value, generator, collapse);
            }
        }
    }


    partial class TfaConfiguration
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTfaConfiguration(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TfaConfiguration)value, generator);
            }
        }
    }


    partial class TfaPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTfaPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TfaPolicy)value, generator);
            }
        }
    }


    partial class TeamMemberLogInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamMemberLogInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamMemberLogInfo)value, generator, collapse);
            }
        }
    }


    partial class TfaRemoveBackupPhoneDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaRemoveBackupPhoneDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaRemoveBackupPhoneDetails)value, generator, collapse);
            }
        }
    }


    partial class TfaRemoveSecurityKeyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTfaRemoveSecurityKeyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TfaRemoveSecurityKeyDetails)value, generator, collapse);
            }
        }
    }


    partial class FileCommentNotificationPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFileCommentNotificationPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FileCommentNotificationPolicy)value, generator);
            }
        }
    }


    partial class TeamMembershipType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamMembershipType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamMembershipType)value, generator);
            }
        }
    }


    partial class FileCommentsChangePolicyDetails
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileCommentsChangePolicyDetails(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileCommentsChangePolicyDetails)value, generator, collapse);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Userscommon
{

    partial class AccountType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAccountType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AccountType)value, generator);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Team
{

    partial class ActiveWebSession
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeActiveWebSession(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ActiveWebSession)value, generator, collapse);
            }
        }
    }


    partial class AdminTier
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAdminTier(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AdminTier)value, generator);
            }
        }
    }


    partial class FeaturesGetValuesBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFeaturesGetValuesBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FeaturesGetValuesBatchResult)value, generator, collapse);
            }
        }
    }


    partial class ApiApp
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeApiApp(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ApiApp)value, generator, collapse);
            }
        }
    }


    partial class CustomQuotaError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeCustomQuotaError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((CustomQuotaError)value, generator);
            }
        }
    }


    partial class GetActivityReport
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetActivityReport(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetActivityReport)value, generator, collapse);
            }
        }
    }


    partial class GetDevicesReport
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetDevicesReport(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetDevicesReport)value, generator, collapse);
            }
        }
    }


    partial class CustomQuotaResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeCustomQuotaResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((CustomQuotaResult)value, generator);
            }
        }
    }


    partial class DateRangeError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDateRangeError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DateRangeError)value, generator);
            }
        }
    }


    partial class GetMembershipReport
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetMembershipReport(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetMembershipReport)value, generator, collapse);
            }
        }
    }


    partial class GetStorageReport
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetStorageReport(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetStorageReport)value, generator, collapse);
            }
        }
    }


    partial class GroupAccessType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupAccessType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupAccessType)value, generator);
            }
        }
    }


    partial class GroupUpdateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupUpdateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupUpdateError)value, generator);
            }
        }
    }


    partial class GroupCreateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupCreateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupCreateError)value, generator);
            }
        }
    }


    partial class GroupsGetInfoError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupsGetInfoError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupsGetInfoError)value, generator);
            }
        }
    }


    partial class GroupDeleteError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupDeleteError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupDeleteError)value, generator);
            }
        }
    }


    partial class GroupsGetInfoItem
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupsGetInfoItem(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupsGetInfoItem)value, generator);
            }
        }
    }


    partial class GroupFullInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupFullInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupFullInfo)value, generator, collapse);
            }
        }
    }


    partial class GroupsListContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupsListContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupsListContinueError)value, generator);
            }
        }
    }


    partial class GroupMemberInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupMemberInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupMemberInfo)value, generator, collapse);
            }
        }
    }


    partial class GroupMemberSetAccessTypeError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupMemberSetAccessTypeError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupMemberSetAccessTypeError)value, generator);
            }
        }
    }


    partial class GroupsListResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupsListResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupsListResult)value, generator, collapse);
            }
        }
    }


    partial class GroupsMembersListContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupsMembersListContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupsMembersListContinueError)value, generator);
            }
        }
    }


    partial class DesktopClientSession
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDesktopClientSession(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DesktopClientSession)value, generator, collapse);
            }
        }
    }


    partial class GroupsMembersListResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupsMembersListResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupsMembersListResult)value, generator, collapse);
            }
        }
    }


    partial class GroupMembersAddError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupMembersAddError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupMembersAddError)value, generator);
            }
        }
    }


    partial class DesktopPlatform
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDesktopPlatform(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DesktopPlatform)value, generator);
            }
        }
    }


    partial class GroupsPollError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupsPollError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupsPollError)value, generator);
            }
        }
    }


    partial class GroupsSelector
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupsSelector(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupsSelector)value, generator);
            }
        }
    }


    partial class GroupMembersChangeResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupMembersChangeResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupMembersChangeResult)value, generator, collapse);
            }
        }
    }


    partial class DeviceSessionArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeviceSessionArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeviceSessionArg)value, generator, collapse);
            }
        }
    }


    partial class HasTeamSharedDropboxValue
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeHasTeamSharedDropboxValue(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((HasTeamSharedDropboxValue)value, generator);
            }
        }
    }


    partial class GroupMembersRemoveError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupMembersRemoveError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupMembersRemoveError)value, generator);
            }
        }
    }


    partial class DevicesActive
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDevicesActive(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DevicesActive)value, generator, collapse);
            }
        }
    }


    partial class GroupSelector
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupSelector(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupSelector)value, generator);
            }
        }
    }


    partial class ListMemberAppsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListMemberAppsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListMemberAppsError)value, generator);
            }
        }
    }


    partial class Feature
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFeature(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((Feature)value, generator);
            }
        }
    }


    partial class ListMemberAppsResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListMemberAppsResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListMemberAppsResult)value, generator, collapse);
            }
        }
    }


    partial class GroupSelectorError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupSelectorError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupSelectorError)value, generator);
            }
        }
    }


    partial class FeatureValue
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFeatureValue(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FeatureValue)value, generator);
            }
        }
    }


    partial class ListMemberDevicesError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListMemberDevicesError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListMemberDevicesError)value, generator);
            }
        }
    }


    partial class FeaturesGetValuesBatchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeFeaturesGetValuesBatchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((FeaturesGetValuesBatchError)value, generator);
            }
        }
    }


    partial class ListMemberDevicesResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListMemberDevicesResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListMemberDevicesResult)value, generator, collapse);
            }
        }
    }


    partial class MemberDevices
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberDevices(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberDevices)value, generator, collapse);
            }
        }
    }


    partial class ListMembersAppsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListMembersAppsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListMembersAppsError)value, generator);
            }
        }
    }


    partial class MembersGetInfoItem
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersGetInfoItem(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersGetInfoItem)value, generator);
            }
        }
    }


    partial class MemberLinkedApps
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberLinkedApps(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberLinkedApps)value, generator, collapse);
            }
        }
    }


    partial class ListMembersAppsResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListMembersAppsResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListMembersAppsResult)value, generator, collapse);
            }
        }
    }


    partial class MembersListContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersListContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersListContinueError)value, generator);
            }
        }
    }


    partial class ListMembersDevicesError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListMembersDevicesError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListMembersDevicesError)value, generator);
            }
        }
    }


    partial class ListMembersDevicesResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListMembersDevicesResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListMembersDevicesResult)value, generator, collapse);
            }
        }
    }


    partial class MemberProfile
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberProfile(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberProfile)value, generator, collapse);
            }
        }
    }


    partial class MembersListError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersListError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersListError)value, generator);
            }
        }
    }


    partial class ListTeamAppsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListTeamAppsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListTeamAppsError)value, generator);
            }
        }
    }


    partial class MembersListResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMembersListResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MembersListResult)value, generator, collapse);
            }
        }
    }


    partial class MembersAddJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersAddJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersAddJobStatus)value, generator);
            }
        }
    }


    partial class MembersRecoverError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersRecoverError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersRecoverError)value, generator);
            }
        }
    }


    partial class ListTeamAppsResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListTeamAppsResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListTeamAppsResult)value, generator, collapse);
            }
        }
    }


    partial class ListTeamDevicesError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListTeamDevicesError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListTeamDevicesError)value, generator);
            }
        }
    }


    partial class MembersRemoveError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersRemoveError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersRemoveError)value, generator);
            }
        }
    }


    partial class MembersAddLaunch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersAddLaunch(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersAddLaunch)value, generator);
            }
        }
    }


    partial class ListTeamDevicesResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListTeamDevicesResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListTeamDevicesResult)value, generator, collapse);
            }
        }
    }


    partial class MembersSendWelcomeError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersSendWelcomeError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersSendWelcomeError)value, generator);
            }
        }
    }


    partial class MembersGetInfoError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersGetInfoError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersGetInfoError)value, generator);
            }
        }
    }


    partial class MemberAccess
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberAccess(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberAccess)value, generator, collapse);
            }
        }
    }


    partial class MembersSetPermissionsResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMembersSetPermissionsResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MembersSetPermissionsResult)value, generator, collapse);
            }
        }
    }


    partial class MembersSetPermissionsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersSetPermissionsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersSetPermissionsError)value, generator);
            }
        }
    }


    partial class MembersUnsuspendError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersUnsuspendError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersUnsuspendError)value, generator);
            }
        }
    }


    partial class MembersSetProfileError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersSetProfileError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersSetProfileError)value, generator);
            }
        }
    }


    partial class MobileClientPlatform
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMobileClientPlatform(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MobileClientPlatform)value, generator);
            }
        }
    }


    partial class MemberAddArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMemberAddArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MemberAddArg)value, generator, collapse);
            }
        }
    }


    partial class MembersSuspendError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMembersSuspendError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MembersSuspendError)value, generator);
            }
        }
    }


    partial class MobileClientSession
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMobileClientSession(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MobileClientSession)value, generator, collapse);
            }
        }
    }


    partial class MemberAddResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMemberAddResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MemberAddResult)value, generator);
            }
        }
    }


    partial class NamespaceMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeNamespaceMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((NamespaceMetadata)value, generator, collapse);
            }
        }
    }


    partial class RevokeDeviceSessionBatchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRevokeDeviceSessionBatchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RevokeDeviceSessionBatchError)value, generator);
            }
        }
    }


    partial class NamespaceType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeNamespaceType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((NamespaceType)value, generator);
            }
        }
    }


    partial class RevokeDeviceSessionBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRevokeDeviceSessionBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RevokeDeviceSessionBatchResult)value, generator, collapse);
            }
        }
    }


    partial class RemoveCustomQuotaResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRemoveCustomQuotaResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RemoveCustomQuotaResult)value, generator);
            }
        }
    }


    partial class RevokeDeviceSessionError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRevokeDeviceSessionError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RevokeDeviceSessionError)value, generator);
            }
        }
    }


    partial class RevokeLinkedApiAppArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRevokeLinkedApiAppArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RevokeLinkedApiAppArg)value, generator, collapse);
            }
        }
    }


    partial class RemovedStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRemovedStatus(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RemovedStatus)value, generator, collapse);
            }
        }
    }


    partial class RevokeLinkedAppBatchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRevokeLinkedAppBatchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RevokeLinkedAppBatchError)value, generator);
            }
        }
    }


    partial class RevokeDeviceSessionStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRevokeDeviceSessionStatus(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RevokeDeviceSessionStatus)value, generator, collapse);
            }
        }
    }


    partial class RevokeDesktopClientArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRevokeDesktopClientArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RevokeDesktopClientArg)value, generator, collapse);
            }
        }
    }


    partial class RevokeDeviceSessionArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRevokeDeviceSessionArg(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RevokeDeviceSessionArg)value, generator);
            }
        }
    }


    partial class RevokeLinkedAppBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRevokeLinkedAppBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RevokeLinkedAppBatchResult)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderListResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderListResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderListResult)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderGetInfoItem
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderGetInfoItem(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderGetInfoItem)value, generator);
            }
        }
    }


    partial class RevokeLinkedAppError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRevokeLinkedAppError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RevokeLinkedAppError)value, generator);
            }
        }
    }


    partial class TeamFolderMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderMetadata)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderPermanentlyDeleteError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderPermanentlyDeleteError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderPermanentlyDeleteError)value, generator);
            }
        }
    }


    partial class TeamFolderInvalidStatusError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderInvalidStatusError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderInvalidStatusError)value, generator);
            }
        }
    }


    partial class TokenGetAuthenticatedAdminResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTokenGetAuthenticatedAdminResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TokenGetAuthenticatedAdminResult)value, generator, collapse);
            }
        }
    }


    partial class RevokeLinkedAppStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRevokeLinkedAppStatus(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RevokeLinkedAppStatus)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderListContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderListContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderListContinueError)value, generator);
            }
        }
    }


    partial class UploadApiRateLimitValue
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadApiRateLimitValue(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadApiRateLimitValue)value, generator);
            }
        }
    }


    partial class StorageBucket
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeStorageBucket(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((StorageBucket)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderListError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamFolderListError(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamFolderListError)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderRenameError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderRenameError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderRenameError)value, generator);
            }
        }
    }


    partial class TeamFolderAccessError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderAccessError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderAccessError)value, generator);
            }
        }
    }


    partial class UserCustomQuotaArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserCustomQuotaArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserCustomQuotaArg)value, generator, collapse);
            }
        }
    }


    partial class UserCustomQuotaResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUserCustomQuotaResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UserCustomQuotaResult)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderStatus)value, generator);
            }
        }
    }


    partial class TeamFolderTeamSharedDropboxError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderTeamSharedDropboxError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderTeamSharedDropboxError)value, generator);
            }
        }
    }


    partial class UserSelectorArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUserSelectorArg(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UserSelectorArg)value, generator);
            }
        }
    }


    partial class TeamFolderActivateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderActivateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderActivateError)value, generator);
            }
        }
    }


    partial class TeamGetInfoResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamGetInfoResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamGetInfoResult)value, generator, collapse);
            }
        }
    }


    partial class TeamMemberInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamMemberInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamMemberInfo)value, generator, collapse);
            }
        }
    }


    partial class TeamMemberProfile
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamMemberProfile(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamMemberProfile)value, generator, collapse);
            }
        }
    }


    partial class TeamFolderArchiveError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderArchiveError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderArchiveError)value, generator);
            }
        }
    }


    partial class TeamMemberStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamMemberStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamMemberStatus)value, generator);
            }
        }
    }


    partial class TeamMembershipType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamMembershipType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamMembershipType)value, generator);
            }
        }
    }


    partial class TeamFolderArchiveJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderArchiveJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderArchiveJobStatus)value, generator);
            }
        }
    }


    partial class TeamNamespacesListContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamNamespacesListContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamNamespacesListContinueError)value, generator);
            }
        }
    }


    partial class TeamFolderArchiveLaunch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderArchiveLaunch(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderArchiveLaunch)value, generator);
            }
        }
    }


    partial class TeamNamespacesListResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamNamespacesListResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamNamespacesListResult)value, generator, collapse);
            }
        }
    }


    partial class TokenGetAuthenticatedAdminError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTokenGetAuthenticatedAdminError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TokenGetAuthenticatedAdminError)value, generator);
            }
        }
    }


    partial class TeamFolderCreateError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeTeamFolderCreateError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((TeamFolderCreateError)value, generator);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Filerequests
{

    partial class CreateFileRequestError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeCreateFileRequestError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((CreateFileRequestError)value, generator);
            }
        }
    }


    partial class GetFileRequestError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetFileRequestError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetFileRequestError)value, generator);
            }
        }
    }


    partial class GracePeriod
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGracePeriod(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GracePeriod)value, generator);
            }
        }
    }


    partial class FileRequest
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequest(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequest)value, generator, collapse);
            }
        }
    }


    partial class FileRequestDeadline
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileRequestDeadline(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileRequestDeadline)value, generator, collapse);
            }
        }
    }


    partial class ListFileRequestsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFileRequestsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFileRequestsError)value, generator);
            }
        }
    }


    partial class ListFileRequestsResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFileRequestsResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFileRequestsResult)value, generator, collapse);
            }
        }
    }


    partial class UpdateFileRequestDeadline
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUpdateFileRequestDeadline(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UpdateFileRequestDeadline)value, generator);
            }
        }
    }


    partial class UpdateFileRequestError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUpdateFileRequestError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UpdateFileRequestError)value, generator);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Files
{

    partial class AlphaGetMetadataError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeAlphaGetMetadataError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((AlphaGetMetadataError)value, generator);
            }
        }
    }


    partial class CommitInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeCommitInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((CommitInfo)value, generator, collapse);
            }
        }
    }


    partial class CreateFolderError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeCreateFolderError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((CreateFolderError)value, generator);
            }
        }
    }


    partial class CreateFolderResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeCreateFolderResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((CreateFolderResult)value, generator, collapse);
            }
        }
    }


    partial class DeleteArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeleteArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeleteArg)value, generator, collapse);
            }
        }
    }


    partial class DeleteBatchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeleteBatchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeleteBatchError)value, generator);
            }
        }
    }


    partial class DeleteBatchJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeleteBatchJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeleteBatchJobStatus)value, generator);
            }
        }
    }


    partial class FolderSharingInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFolderSharingInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FolderSharingInfo)value, generator, collapse);
            }
        }
    }


    partial class GetCopyReferenceError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetCopyReferenceError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetCopyReferenceError)value, generator);
            }
        }
    }


    partial class GetCopyReferenceResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetCopyReferenceResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetCopyReferenceResult)value, generator, collapse);
            }
        }
    }


    partial class GetMetadataError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetMetadataError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetMetadataError)value, generator);
            }
        }
    }


    partial class GetTemporaryLinkError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetTemporaryLinkError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetTemporaryLinkError)value, generator);
            }
        }
    }


    partial class GetTemporaryLinkResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetTemporaryLinkResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetTemporaryLinkResult)value, generator, collapse);
            }
        }
    }


    partial class GetThumbnailBatchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetThumbnailBatchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetThumbnailBatchError)value, generator);
            }
        }
    }


    partial class GpsCoordinates
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGpsCoordinates(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GpsCoordinates)value, generator, collapse);
            }
        }
    }


    partial class GetThumbnailBatchResultData
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetThumbnailBatchResultData(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetThumbnailBatchResultData)value, generator, collapse);
            }
        }
    }


    partial class GetThumbnailBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGetThumbnailBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GetThumbnailBatchResult)value, generator, collapse);
            }
        }
    }


    partial class ListFolderLongpollResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFolderLongpollResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFolderLongpollResult)value, generator, collapse);
            }
        }
    }


    partial class ListFolderContinueError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFolderContinueError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFolderContinueError)value, generator);
            }
        }
    }


    partial class DeleteBatchLaunch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeleteBatchLaunch(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeleteBatchLaunch)value, generator);
            }
        }
    }


    partial class ListFolderResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFolderResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFolderResult)value, generator, collapse);
            }
        }
    }


    partial class DeleteBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeleteBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeleteBatchResult)value, generator, collapse);
            }
        }
    }


    partial class LookupError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeLookupError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((LookupError)value, generator);
            }
        }
    }


    partial class ListFolderError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFolderError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFolderError)value, generator);
            }
        }
    }


    partial class ListRevisionsError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListRevisionsError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListRevisionsError)value, generator);
            }
        }
    }


    partial class GetThumbnailBatchResultEntry
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetThumbnailBatchResultEntry(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetThumbnailBatchResultEntry)value, generator);
            }
        }
    }


    partial class DeleteBatchResultData
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeleteBatchResultData(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeleteBatchResultData)value, generator, collapse);
            }
        }
    }


    partial class MediaInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeMediaInfo(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((MediaInfo)value, generator);
            }
        }
    }


    partial class ListRevisionsResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListRevisionsResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListRevisionsResult)value, generator, collapse);
            }
        }
    }


    partial class ListFolderGetLatestCursorResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeListFolderGetLatestCursorResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ListFolderGetLatestCursorResult)value, generator, collapse);
            }
        }
    }


    partial class Metadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((Metadata)value, generator, collapse);
            }
        }
    }


    partial class RestoreError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRestoreError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RestoreError)value, generator);
            }
        }
    }


    partial class RelocationPath
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRelocationPath(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RelocationPath)value, generator, collapse);
            }
        }
    }


    partial class ListFolderLongpollError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeListFolderLongpollError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ListFolderLongpollError)value, generator);
            }
        }
    }


    partial class DeleteBatchResultEntry
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeleteBatchResultEntry(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeleteBatchResultEntry)value, generator);
            }
        }
    }


    partial class RelocationResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRelocationResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RelocationResult)value, generator, collapse);
            }
        }
    }


    partial class SearchMatchType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSearchMatchType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SearchMatchType)value, generator);
            }
        }
    }


    partial class UploadSessionCursor
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUploadSessionCursor(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UploadSessionCursor)value, generator, collapse);
            }
        }
    }


    partial class DeleteError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDeleteError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DeleteError)value, generator);
            }
        }
    }


    partial class UploadSessionFinishArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUploadSessionFinishArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UploadSessionFinishArg)value, generator, collapse);
            }
        }
    }


    partial class SearchMode
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSearchMode(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SearchMode)value, generator);
            }
        }
    }


    partial class MediaMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeMediaMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((MediaMetadata)value, generator, collapse);
            }
        }
    }


    partial class SaveCopyReferenceError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSaveCopyReferenceError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SaveCopyReferenceError)value, generator);
            }
        }
    }


    partial class UploadSessionFinishBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUploadSessionFinishBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UploadSessionFinishBatchResult)value, generator, collapse);
            }
        }
    }


    partial class SearchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSearchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SearchResult)value, generator, collapse);
            }
        }
    }


    partial class UploadSessionFinishBatchResultEntry
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadSessionFinishBatchResultEntry(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadSessionFinishBatchResultEntry)value, generator);
            }
        }
    }


    partial class DeleteResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeleteResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeleteResult)value, generator, collapse);
            }
        }
    }


    partial class PhotoMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializePhotoMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((PhotoMetadata)value, generator, collapse);
            }
        }
    }


    partial class UploadSessionLookupError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadSessionLookupError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadSessionLookupError)value, generator);
            }
        }
    }


    partial class UploadSessionOffsetError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUploadSessionOffsetError(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UploadSessionOffsetError)value, generator, collapse);
            }
        }
    }


    partial class SaveCopyReferenceResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSaveCopyReferenceResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SaveCopyReferenceResult)value, generator, collapse);
            }
        }
    }


    partial class DeletedMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDeletedMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((DeletedMetadata)value, generator, collapse);
            }
        }
    }


    partial class PreviewError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePreviewError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PreviewError)value, generator);
            }
        }
    }


    partial class UploadSessionStartResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUploadSessionStartResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UploadSessionStartResult)value, generator, collapse);
            }
        }
    }


    partial class SaveUrlError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSaveUrlError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SaveUrlError)value, generator);
            }
        }
    }


    partial class UploadSessionFinishBatchJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadSessionFinishBatchJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadSessionFinishBatchJobStatus)value, generator);
            }
        }
    }


    partial class VideoMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeVideoMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((VideoMetadata)value, generator, collapse);
            }
        }
    }


    partial class UploadSessionFinishError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadSessionFinishError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadSessionFinishError)value, generator);
            }
        }
    }


    partial class WriteError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeWriteError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((WriteError)value, generator);
            }
        }
    }


    partial class UploadWriteFailed
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeUploadWriteFailed(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((UploadWriteFailed)value, generator, collapse);
            }
        }
    }


    partial class UploadSessionFinishBatchLaunch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadSessionFinishBatchLaunch(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadSessionFinishBatchLaunch)value, generator);
            }
        }
    }


    partial class WriteConflictError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeWriteConflictError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((WriteConflictError)value, generator);
            }
        }
    }


    partial class SaveUrlJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSaveUrlJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SaveUrlJobStatus)value, generator);
            }
        }
    }


    partial class Dimensions
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeDimensions(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((Dimensions)value, generator, collapse);
            }
        }
    }


    partial class RelocationBatchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRelocationBatchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RelocationBatchError)value, generator);
            }
        }
    }


    partial class ThumbnailArg
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeThumbnailArg(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((ThumbnailArg)value, generator, collapse);
            }
        }
    }


    partial class SaveUrlResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSaveUrlResult(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SaveUrlResult)value, generator);
            }
        }
    }


    partial class DownloadError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeDownloadError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((DownloadError)value, generator);
            }
        }
    }


    partial class ThumbnailError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeThumbnailError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ThumbnailError)value, generator);
            }
        }
    }


    partial class RelocationBatchJobStatus
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRelocationBatchJobStatus(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RelocationBatchJobStatus)value, generator);
            }
        }
    }


    partial class WriteMode
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeWriteMode(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((WriteMode)value, generator);
            }
        }
    }


    partial class ThumbnailFormat
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeThumbnailFormat(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ThumbnailFormat)value, generator);
            }
        }
    }


    partial class SearchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSearchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SearchError)value, generator);
            }
        }
    }


    partial class RelocationBatchLaunch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRelocationBatchLaunch(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RelocationBatchLaunch)value, generator);
            }
        }
    }


    partial class ThumbnailSize
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeThumbnailSize(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((ThumbnailSize)value, generator);
            }
        }
    }


    partial class RelocationBatchResult
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRelocationBatchResult(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RelocationBatchResult)value, generator, collapse);
            }
        }
    }


    partial class FileMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileMetadata)value, generator, collapse);
            }
        }
    }


    partial class SearchMatch
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSearchMatch(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SearchMatch)value, generator, collapse);
            }
        }
    }


    partial class RelocationBatchResultData
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeRelocationBatchResultData(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((RelocationBatchResultData)value, generator, collapse);
            }
        }
    }


    partial class UploadError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadError)value, generator);
            }
        }
    }


    partial class FileSharingInfo
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFileSharingInfo(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FileSharingInfo)value, generator, collapse);
            }
        }
    }


    partial class UploadErrorWithProperties
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeUploadErrorWithProperties(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((UploadErrorWithProperties)value, generator);
            }
        }
    }


    partial class RelocationError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRelocationError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RelocationError)value, generator);
            }
        }
    }


    partial class FolderMetadata
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFolderMetadata(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FolderMetadata)value, generator, collapse);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Teamcommon
{

    partial class GroupManagementType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupManagementType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupManagementType)value, generator);
            }
        }
    }


    partial class GroupSummary
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeGroupSummary(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((GroupSummary)value, generator, collapse);
            }
        }
    }


    partial class GroupType
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGroupType(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GroupType)value, generator);
            }
        }
    }


    partial class TimeRange
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTimeRange(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TimeRange)value, generator, collapse);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Teampolicies
{

    partial class EmmState
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeEmmState(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((EmmState)value, generator);
            }
        }
    }


    partial class OfficeAddInPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeOfficeAddInPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((OfficeAddInPolicy)value, generator);
            }
        }
    }


    partial class PaperDeploymentPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperDeploymentPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperDeploymentPolicy)value, generator);
            }
        }
    }


    partial class PaperEnabledPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializePaperEnabledPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((PaperEnabledPolicy)value, generator);
            }
        }
    }


    partial class RolloutMethod
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeRolloutMethod(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((RolloutMethod)value, generator);
            }
        }
    }


    partial class SharedFolderJoinPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedFolderJoinPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedFolderJoinPolicy)value, generator);
            }
        }
    }


    partial class SharedFolderMemberPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedFolderMemberPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedFolderMemberPolicy)value, generator);
            }
        }
    }


    partial class SharedLinkCreatePolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSharedLinkCreatePolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SharedLinkCreatePolicy)value, generator);
            }
        }
    }


    partial class SsoPolicy
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSsoPolicy(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SsoPolicy)value, generator);
            }
        }
    }


    partial class TeamMemberPolicies
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamMemberPolicies(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamMemberPolicies)value, generator, collapse);
            }
        }
    }


    partial class TeamSharingPolicies
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamSharingPolicies(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamSharingPolicies)value, generator, collapse);
            }
        }
    }

}


namespace Com.Dropbox.Core.V2.Users
{

    partial class BasicAccount
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeBasicAccount(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((BasicAccount)value, generator, collapse);
            }
        }
    }


    partial class GetAccountBatchError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetAccountBatchError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetAccountBatchError)value, generator);
            }
        }
    }


    partial class FullTeam
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFullTeam(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FullTeam)value, generator, collapse);
            }
        }
    }


    partial class GetAccountError
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeGetAccountError(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((GetAccountError)value, generator);
            }
        }
    }


    partial class IndividualSpaceAllocation
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeIndividualSpaceAllocation(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((IndividualSpaceAllocation)value, generator, collapse);
            }
        }
    }


    partial class FullAccount
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeFullAccount(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((FullAccount)value, generator, collapse);
            }
        }
    }


    partial class SpaceUsage
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeSpaceUsage(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((SpaceUsage)value, generator, collapse);
            }
        }
    }


    partial class Name
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeName(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((Name)value, generator, collapse);
            }
        }
    }


    partial class Team
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeam(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((Team)value, generator, collapse);
            }
        }
    }


    partial class SpaceAllocation
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser)
            {
                return DeserializeSpaceAllocation(parser);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator)
            {
                Serialize((SpaceAllocation)value, generator);
            }
        }
    }


    partial class TeamSpaceAllocation
    {
        partial class Serializer
        {
            public override unsafe Java.Lang.Object Deserialize(FasterXml.Jackson.Core.JsonParser parser, bool collapsed)
            {
                return DeserializeTeamSpaceAllocation(parser, collapsed);
            }

            public override unsafe void Serialize(Java.Lang.Object value, FasterXml.Jackson.Core.JsonGenerator generator, bool collapse)
            {
                Serialize((TeamSpaceAllocation)value, generator, collapse);
            }
        }
    }

}
