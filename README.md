# Transmitly.ChannelProvider.Twilio.Configuration

Shared Twilio configuration and extension contracts for Transmitly channel providers.

## Should you use this package?

Use this package if you are building or extending a Twilio provider for the Transmitly ecosystem and need the shared Twilio option types, channel extensions, and delivery-report contracts.

If you are building an application and just want to send SMS or voice calls through Twilio, use [`Transmitly.ChannelProvider.Twilio`](https://github.com/transmitly/transmitly-channel-provider-twilio) instead.

## What This Package Provides

- `TwilioClientOptions` with `AccountSid`, `AuthToken`, `WebProxy`, `Edge`, `Region`, and provider user-agent support.
- `ChannelProviders.Twilio(providerId)` for resolving a Transmitly channel-provider id.
- `sms.Twilio()` and `voice.Twilio()` channel-specific extension points.
- SMS contracts for messaging-service selection and status callbacks.
- Voice contracts for status callbacks, TwiML URL resolution, timeouts, machine detection, and message-storage hooks.
- Twilio SMS and voice delivery-report contracts.
- Builder extensions for registering SMS, voice, and delivery-report adaptors.

## Related Packages

- [Transmitly](https://github.com/transmitly/transmitly)
- [Transmitly.ChannelProvider.Twilio](https://github.com/transmitly/transmitly-channel-provider-twilio)
- [Transmitly.ChannelProvider.Twilio.Sdk](https://github.com/transmitly/transmitly-channel-provider-twilio-sdk)

---
_Copyright (c) Code Impressions, LLC. This open-source project is sponsored and maintained by Code Impressions and is licensed under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html)._
