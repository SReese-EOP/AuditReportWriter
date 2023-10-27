# The Executive Office of the President (EOP) Enterprise GitHub Security Policy

<!-- TABLE OF CONTENTS -->

### Table of Contents

<ol>
  <li><a href="#security">Security</a></li>
  <li><a href="#scanning">Scanning</a></li>
  <li><a href="#reporting">Reporting</a></li>
  <li><a href="#policy">Policy</a></li>
  <li><a href="#mailing">Mailing Lists</a></li>
  <li><a href="#confidentiality-integrity-and-availability">Confidentiality Integrity and Availability</a></li>
</ol>

### Security

The EOP takes the security of our software products and services seriously, which includes all source code repositories managed through our GitHub organizations, which include [OA-WhiteHouse-gov](https://github.com/WhiteHouse), [OA-Salesforce](https://github.com/OA-Salesforce), [OA-OBS](https://github.com/OA-OBS) and all of our GitHub organizations.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

### Scanning

The following Github Advanced Code Scanning features must be enabled:

1. CodeQL must be enabled for the languages used and enable for alerts on the repo and alerts for Pull requests.
   - If the languange being used is not covered by the current scanning tool, please notify the security team so that an alternative solution can be found.
2. Dependabot must be enabled for the repo.
3. Secrets Scanning must be enabled for the repo.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

### Reporting

Please do not report security issues through public GitHub issues.

Instead, please report issues to the EOP Security team to [DL.EOP.CloudAdmin@eop.gov](mailto:DL.EOP.CloudAdmin@eop.gov).

The CAS (Cyber Application Security) team will respond within 24 hours to issues and concerns, if no response is given please follow up via email to ensure we received your original message.

Please include the requested information listed below (as much as you can provide) to help us better understand the nature and scope of the possible issue:

- Type of issue (e.g. buffer overflow, SQL injection, cross-site scripting, etc.)
- Full paths of source file(s) related to the manifestation of the issue
- The location of the affected source code (tag/branch/commit or direct URL)
- Any special configuration required to reproduce the issue
- Step-by-step instructions to reproduce the issue
- Proof-of-concept or exploit code (if possible)
- Impact of the issue, including how an attacker might exploit the issue

This information will help us triage your report more quickly.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

### Policy

All source code, derivative source code, derivative works and copies, in whole or in part, are and shall remain the property of the EOP. Also, the creation of public repositories is prohibited within the EOP Enterprise GitHub.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

### Mailing

In the unfortunate event that you share information beyond what is permitted by this policy, you must urgently inform the [DL.EOP.CloudAdmin@eop.gov](mailto:DL.EOP.CloudAdmin@eop.gov) mailing list of exactly what information was leaked and to whom.

<p align="right">(<a href="#table-of-contents">back to top</a>)</p>

### Confidentiality Integrity and Availability

We consider vulnerabilities leading to the compromise of data confidentiality, elevation of privilege, or integrity to be our highest priority concerns. Availability, in particular in areas relating to DoS and resource exhaustion, is also a serious security concern. The White House Security Team takes all vulnerabilities, potential vulnerabilities, and suspected vulnerabilities seriously and will investigate them in an urgent and expeditious manner.
