// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The SyslogDataSourceFacilityName. </summary>
    public readonly partial struct SyslogDataSourceFacilityName : IEquatable<SyslogDataSourceFacilityName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyslogDataSourceFacilityName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyslogDataSourceFacilityName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlertValue = "alert";
        private const string AuditValue = "audit";
        private const string AuthValue = "auth";
        private const string AuthprivValue = "authpriv";
        private const string ClockValue = "clock";
        private const string CronValue = "cron";
        private const string DaemonValue = "daemon";
        private const string FtpValue = "ftp";
        private const string KernValue = "kern";
        private const string LprValue = "lpr";
        private const string MailValue = "mail";
        private const string MarkValue = "mark";
        private const string NewsValue = "news";
        private const string NopriValue = "nopri";
        private const string NtpValue = "ntp";
        private const string SyslogValue = "syslog";
        private const string UserValue = "user";
        private const string UucpValue = "uucp";
        private const string Local0Value = "local0";
        private const string Local1Value = "local1";
        private const string Local2Value = "local2";
        private const string Local3Value = "local3";
        private const string Local4Value = "local4";
        private const string Local5Value = "local5";
        private const string Local6Value = "local6";
        private const string Local7Value = "local7";
        private const string AsteriskValue = "*";

        /// <summary> alert. </summary>
        public static SyslogDataSourceFacilityName Alert { get; } = new SyslogDataSourceFacilityName(AlertValue);
        /// <summary> audit. </summary>
        public static SyslogDataSourceFacilityName Audit { get; } = new SyslogDataSourceFacilityName(AuditValue);
        /// <summary> auth. </summary>
        public static SyslogDataSourceFacilityName Auth { get; } = new SyslogDataSourceFacilityName(AuthValue);
        /// <summary> authpriv. </summary>
        public static SyslogDataSourceFacilityName Authpriv { get; } = new SyslogDataSourceFacilityName(AuthprivValue);
        /// <summary> clock. </summary>
        public static SyslogDataSourceFacilityName Clock { get; } = new SyslogDataSourceFacilityName(ClockValue);
        /// <summary> cron. </summary>
        public static SyslogDataSourceFacilityName Cron { get; } = new SyslogDataSourceFacilityName(CronValue);
        /// <summary> daemon. </summary>
        public static SyslogDataSourceFacilityName Daemon { get; } = new SyslogDataSourceFacilityName(DaemonValue);
        /// <summary> ftp. </summary>
        public static SyslogDataSourceFacilityName Ftp { get; } = new SyslogDataSourceFacilityName(FtpValue);
        /// <summary> kern. </summary>
        public static SyslogDataSourceFacilityName Kern { get; } = new SyslogDataSourceFacilityName(KernValue);
        /// <summary> lpr. </summary>
        public static SyslogDataSourceFacilityName Lpr { get; } = new SyslogDataSourceFacilityName(LprValue);
        /// <summary> mail. </summary>
        public static SyslogDataSourceFacilityName Mail { get; } = new SyslogDataSourceFacilityName(MailValue);
        /// <summary> mark. </summary>
        public static SyslogDataSourceFacilityName Mark { get; } = new SyslogDataSourceFacilityName(MarkValue);
        /// <summary> news. </summary>
        public static SyslogDataSourceFacilityName News { get; } = new SyslogDataSourceFacilityName(NewsValue);
        /// <summary> nopri. </summary>
        public static SyslogDataSourceFacilityName Nopri { get; } = new SyslogDataSourceFacilityName(NopriValue);
        /// <summary> ntp. </summary>
        public static SyslogDataSourceFacilityName Ntp { get; } = new SyslogDataSourceFacilityName(NtpValue);
        /// <summary> syslog. </summary>
        public static SyslogDataSourceFacilityName Syslog { get; } = new SyslogDataSourceFacilityName(SyslogValue);
        /// <summary> user. </summary>
        public static SyslogDataSourceFacilityName User { get; } = new SyslogDataSourceFacilityName(UserValue);
        /// <summary> uucp. </summary>
        public static SyslogDataSourceFacilityName Uucp { get; } = new SyslogDataSourceFacilityName(UucpValue);
        /// <summary> local0. </summary>
        public static SyslogDataSourceFacilityName Local0 { get; } = new SyslogDataSourceFacilityName(Local0Value);
        /// <summary> local1. </summary>
        public static SyslogDataSourceFacilityName Local1 { get; } = new SyslogDataSourceFacilityName(Local1Value);
        /// <summary> local2. </summary>
        public static SyslogDataSourceFacilityName Local2 { get; } = new SyslogDataSourceFacilityName(Local2Value);
        /// <summary> local3. </summary>
        public static SyslogDataSourceFacilityName Local3 { get; } = new SyslogDataSourceFacilityName(Local3Value);
        /// <summary> local4. </summary>
        public static SyslogDataSourceFacilityName Local4 { get; } = new SyslogDataSourceFacilityName(Local4Value);
        /// <summary> local5. </summary>
        public static SyslogDataSourceFacilityName Local5 { get; } = new SyslogDataSourceFacilityName(Local5Value);
        /// <summary> local6. </summary>
        public static SyslogDataSourceFacilityName Local6 { get; } = new SyslogDataSourceFacilityName(Local6Value);
        /// <summary> local7. </summary>
        public static SyslogDataSourceFacilityName Local7 { get; } = new SyslogDataSourceFacilityName(Local7Value);
        /// <summary> *. </summary>
        public static SyslogDataSourceFacilityName Asterisk { get; } = new SyslogDataSourceFacilityName(AsteriskValue);
        /// <summary> Determines if two <see cref="SyslogDataSourceFacilityName"/> values are the same. </summary>
        public static bool operator ==(SyslogDataSourceFacilityName left, SyslogDataSourceFacilityName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyslogDataSourceFacilityName"/> values are not the same. </summary>
        public static bool operator !=(SyslogDataSourceFacilityName left, SyslogDataSourceFacilityName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SyslogDataSourceFacilityName"/>. </summary>
        public static implicit operator SyslogDataSourceFacilityName(string value) => new SyslogDataSourceFacilityName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyslogDataSourceFacilityName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyslogDataSourceFacilityName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
