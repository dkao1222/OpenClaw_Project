# Defined Request

## Canonical Fields

- project_name: NeonDrift_MVP
- define_page_id: 386b9e33-8429-81eb-88e9-c892fc5b31cd
- define_run_id: notion-NeonDrift_MVP-define-20260621125426
- agent_model_policy: per-agent-config
- thinking: off

## Product Vision and Purpose（產品願景與目的）

NeonDrift MVP is a fast mobile arcade drifting game built in Unity. The product goal is to validate a lightweight, replayable one-minute game loop that can ship first to iOS, then Android and WebGL, with monetization through rewarded ads after gameplay quality is proven.

## Target Audience（目標受眾）

Mobile casual arcade players age 13+, especially players who enjoy quick reflex games, score chasing, neon racing visuals, and short sessions during breaks. Key pain points are slow onboarding, bloated progression systems, and games that require too much commitment before fun starts.

## Core Value（核心價值）

1. Instant one-tap/one-touch drift control with readable feedback. 2. Clear score, boost/combo, failure, and retry loop for fast replay. 3. Mobile-safe UI with icon, font, background, VFX, safe-area, and compatibility evidence suitable for App Store and Google Play preparation.

## Platform Target

Unity 6000 LTS family, iOS simulator and iOS device first, Android and WebGL secondary. Local Unity build is required; Unity Cloud Build is not used.

## Monetization Direction

Rewarded ads first through AdMob; interstitial ads only after UX and retention review. Apple Developer and AdMob accounts are available. Privacy, ATT, Google Play Data Safety, and App Store privacy labels must be considered.

## Compatibility Target

iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro including notch/Dynamic Island safe area, Android 10+ representative devices, and WebGL desktop browser.

## Output Expectation

Every stage must produce bounded Markdown handoffs, Notion-readable documents, Git-publishable artifacts, Unity source, Unity QA probe, Unity test evidence, local build validation, and local-agent QA result JSON. Handoff, heartbeat, BLOCKED, NO_REPLY, malformed output, missing evidence, or missing path must make the stage fail.

## Development Request

Run the full OpenClaw game pipeline from Define through Planning, Spec Review, Development, Local Unity Build, and local-agent QA. Use Unity QA probe and Unity-generated QA evidence; Codex must not decide QA pass/fail.
