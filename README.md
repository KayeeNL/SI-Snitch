# SI Snitch

SI Snitch is a debugging tool for reading claims passed to Sitecore from Sitecore Identity, after transformation of those claims from Sitecore Identity. It can be helpful in:

- Identifying claims that Sitecore is getting, and in what format.
- Ensuring group transformations in Sitecore Identity are being processed properly.

**_Since SI Snitch dumps all claims into the log file of the system, it's highly recommended that this only be used in development environments. Use at your own risk!!!_**

Original idea & blogpost from Derek on SI Snitch: [Read the blog post here](https://sitecore.derekc.net/sisnitch-small-tool-to-debug-claims-coming-out-of-sitecore-identity/).

## Usage

There are two ways to use this project:

- **Build the solution yourself and deploy the necessary files needed for SI Snitch.**
- **Install a Sitecore package directly on your Sitecore instance.**

### _Build it yourself_:

- Build the SI Snitch solution
- Deploy the SitecoreServices.SISnitch assembly to /bin folder
- Deploy the SitecoreServices.SISnitch.config configuration to the App_Config/Environment folder
- Start up your Sitecore instance and login through Identity Server
- View claims in log files (look for **_'oO SI Snitch Oo'_**).

### _Install through a Sitecore package_:

_Right click 'Save link as...' since GitHub doesn't respect url encoding, but markdown needs it for formatting in this readme ;-)_

- [SI-Snitch for Sitecore-9.3](./Sitecore%20Packages/SI-Snitch%20for%20Sitecore-9.3.zip) ( Sitecore 9.3)
- [SI-Snitch for Sitecore-10.0.0](./Sitecore%20Packages/SI-Snitch%20for%20Sitecore-10.0.0.zip) ( Sitecore 10.0.0)

The above package can be installed through the normal Sitecore Installation Wizard.

## Output of SI Snitch

The following would be an output of SI Snitch in the Sitecore log file:

- 32856 09:01:15 INFO oO SI Snitch Oo -- Claim: nbf || Value: 1604563275
- 32856 09:01:15 INFO oO SI Snitch Oo -- Claim: exp || Value: 1604564775
- 32856 09:01:15 INFO oO SI Snitch Oo -- Claim: iss || Value: https://sc93.identityserver.dev.local
- 32856 09:01:15 INFO oO SI Snitch Oo -- Claim: aud || Value: Sitecore
- 32856 09:01:15 INFO oO SI Snitch Oo -- Claim: iat || Value: 1604563275

etc...Look for **_'oO SI Snitch Oo'_** ;-)

## Support

The code, samples and/or solutions provided in this repository are unsupported by Sitecore. Don't even think of opening a support incident related to issues with this code.

## Warranty

The code, samples and/or solutions provided in this repository are for example purposes only and without warranty (expressed or implied). The code has not been extensively tested and is not guaranteed to be bug free.

# Contributors

_Originally developed by:_

Derek Correia - Twitter: [@derekc](https://twitter.com/derekc), GitHub: https://github.com/derekcorreia

_Upgraded to support Sitecore 9.3 & Sitecore 10.0.0_

Robbert Hock - Twitter: [@kayeeNL](https://twitter.com/kayeenl), GitHub: https://github.com/KayeeNL
