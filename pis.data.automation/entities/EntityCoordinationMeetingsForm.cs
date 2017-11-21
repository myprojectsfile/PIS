﻿using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class EntityCoordinationMeetingsForm
    {
        public int EntityCode { get; set; }
        public int CategoryCode { get; set; }
        public int RaitingHits { get; set; }
        public int? Grade { get; set; }
        public bool? IsPreNote { get; set; }
        public bool Locked { get; set; }
        public bool LocalLock { get; set; }
        public int LocalLockUserCode { get; set; }
        public int LocalLockRoleId { get; set; }
        public int LockUserCode { get; set; }
        public int LockRoleId { get; set; }
        public string FieldsStatus { get; set; }
        public bool IsPrivateSearch { get; set; }
        public int PrivateSearchUserCode { get; set; }
        public int PrivateSearchRoleId { get; set; }
        public DateTime? LastSignatureDate { get; set; }
        public string EntityNumber { get; set; }
        public int NumberOfCopies { get; set; }
        public string Version { get; set; }
        public int OriginalVersionCode { get; set; }
        public bool IsSigned { get; set; }
        public int SecurityLevelCode { get; set; }
        public bool? IsConfirm { get; set; }
        public bool? IsActive { get; set; }
        public int FirstEntityCode { get; set; }
        public string From { get; set; }
        public string ImportEntityNumber { get; set; }
        public DateTime? ImportDate { get; set; }
        public string ImportMethod { get; set; }
        public string ImportDesc { get; set; }
        public string ImportOriginNo { get; set; }
        public DateTime? ImportOriginDate { get; set; }
        public string NopgAttached { get; set; }
        public string To { get; set; }
        public string ExportEntityNumber { get; set; }
        public DateTime? ExportDate { get; set; }
        public string ExportMethod { get; set; }
        public string ExportDesc { get; set; }
        public int? ImportIndicatorId { get; set; }
        public int? ExportIndicatorId { get; set; }
        public int? ImportRegisterId { get; set; }
        public int? ImportRegisterRoleId { get; set; }
        public int? ExportRegisterId { get; set; }
        public int? ExportRegisterRoleId { get; set; }
        public string DocType { get; set; }
        public string DocSubject { get; set; }
        public string DocKeywords { get; set; }
        public int? Priority { get; set; }
        public int? ImportPriority { get; set; }
        public int? ExportPriority { get; set; }
        public int CreatorId { get; set; }
        public int CreatorRoleId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public string MeetingLocation { get; set; }
        public DateTime? MeetingBeginning { get; set; }
        public int? MeetingEnd { get; set; }
        public int? MeetingTime { get; set; }
        public string FeforrtRole { get; set; }
        public string FbVerifyRole { get; set; }
        public string FverifySign { get; set; }
        public string FberifySign { get; set; }
        public string Invitees { get; set; }
        public bool? Lighting { get; set; }
        public bool? Recording { get; set; }
        public bool? Presenter { get; set; }
        public bool? Internet { get; set; }
        public bool? AudioTools { get; set; }
        public bool? VideoTools { get; set; }
        public bool? ConfrenceTools { get; set; }
        public bool? Loptop { get; set; }
        public bool? WiFiMicrophone { get; set; }
        public bool? Bulletin { get; set; }
        public string OtherInformatics { get; set; }
        public bool? MobileMicrophone { get; set; }
        public bool? OneMorning { get; set; }
        public bool? TwoMorning { get; set; }
        public bool? OneEvening { get; set; }
        public bool? TowEvening { get; set; }
        public bool? Lunch { get; set; }
        public bool? Habitation { get; set; }
        public bool? WhitePaper { get; set; }
        public bool? Transportation { get; set; }
        public string OtehrAdministrative { get; set; }
        public bool? Quran { get; set; }
        public bool? MusicGroup { get; set; }
        public bool? FilmRecording { get; set; }
        public bool? PhotoRecording { get; set; }
        public bool? GroupSong { get; set; }
        public bool? ArmyMusic { get; set; }
        public bool? FilmPort { get; set; }
        public string Gift { get; set; }
        public string CdFrInvitees { get; set; }
        public string OtherPrelations { get; set; }
        public bool? Rohani { get; set; }
        public string RohaniTime { get; set; }
        public bool? Guard { get; set; }
        public bool? NetworkAccess { get; set; }
        public string Innercall { get; set; }
        public string Cellphone { get; set; }
        public string Fmeeting { get; set; }
        public string Smeeting { get; set; }
        public bool? MicrophoneY { get; set; }
        public string NomicWireless { get; set; }
        public string FaniOthers { get; set; }
        public bool? Interpreter { get; set; }
        public string Nocd { get; set; }
        public bool? Broshor { get; set; }
        public string BroshornO { get; set; }
        public bool? Countryflag { get; set; }
        public string Azsaate { get; set; }
        public string Dategard { get; set; }
        public string Darb { get; set; }
        public bool? OpticPencil { get; set; }
        public bool? Wirelesshand { get; set; }
        public string Cordinator { get; set; }
        public bool? Cdkhamm { get; set; }
        public string Numcdkham { get; set; }
        public bool? Wielessmouse { get; set; }
        public bool? Softeware { get; set; }
        public string Tozihsoft { get; set; }
        public string Versionnn { get; set; }
        public bool? Paziraei { get; set; }
        public string Pishnahadi { get; set; }
        public string Eskantedad { get; set; }
        public string Dailytedad { get; set; }
        public string Mabda { get; set; }
        public string Saatemabda { get; set; }
        public string Tamaghsad { get; set; }
        public string Aksmabda { get; set; }
        public string Akssaat { get; set; }
        public string Akstamaghsad { get; set; }
        public bool? Mehmankhas { get; set; }
        public bool? Modirkol { get; set; }
        public bool? Atbaekhareji { get; set; }
        public string Tedadhedie { get; set; }
        public int? Paziraeii { get; set; }
        public string MeetingSubject { get; set; }
    }
}
