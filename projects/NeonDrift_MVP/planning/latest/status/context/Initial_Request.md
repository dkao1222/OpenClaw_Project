# Initial Request

project_name: NeonDrift_MVP
workspace_key: 386b9e33-8429-81d3-9ecd-cb103dcf7fa9
run_id: notion-NeonDrift_MVP-0-12-20260621125435
stage_range: 0-12
agent_model_policy: per-agent-config
legacy_model_field_ignored: per-agent-config
thinking: off
requested_by: define:notion-NeonDrift_MVP-define-20260621125426

## Pipeline Execution Policy

The Notion watcher script is the pipeline controller. Each OpenClaw agent is a worker and uses its own model from openclaw.json. The Notion Model field is not used to route the full pipeline through one model.

## Product Vision and Purpose（產品願景與目的）

NeonDrift MVP is a fast mobile arcade drifting game built in Unity. The product goal is to validate a lightweight, replayable one-minute game loop that can ship first to iOS, then Android and WebGL, with monetization through rewarded ads after gameplay quality is proven.

## Target Audience（目標受眾）

Mobile casual arcade players age 13+, especially players who enjoy quick reflex games, score chasing, neon racing visuals, and short sessions during breaks. Key pain points are slow onboarding, bloated progression systems, and games that require too much commitment before fun starts.

## Core Value（核心價值）

1. Instant one-tap/one-touch drift control with readable feedback. 2. Clear score, boost/combo, failure, and retry loop for fast replay. 3. Mobile-safe UI with icon, font, background, VFX, safe-area, and compatibility evidence suitable for App Store and Google Play preparation.

## Development Request

Run the full OpenClaw game pipeline from Define through Planning, Spec Review, Development, Local Unity Build, and local-agent QA. Use Unity QA probe and Unity-generated QA evidence; Codex must not decide QA pass/fail.

Define source:
- define_run_id: notion-NeonDrift_MVP-define-20260621125426
- define_output_folder: /home/node/.openclaw/workspace/386b9e33-8429-81eb-88e9-c892fc5b31cd/NeonDrift_MVP__define__notion-NeonDrift_MVP-define-20260621125426/project/
- define_handoff_path: /home/node/.openclaw/workspace/386b9e33-8429-81eb-88e9-c892fc5b31cd/NeonDrift_MVP__define__notion-NeonDrift_MVP-define-20260621125426/project/handoffs/define/handoff_to_planning.md

Locked define constraints:
- platform_target: Unity 6000 LTS family, iOS simulator and iOS device first, Android and WebGL secondary. Local Unity build is required; Unity Cloud Build is not used.
- monetization_direction: Rewarded ads first through AdMob; interstitial ads only after UX and retention review. Apple Developer and AdMob accounts are available. Privacy, ATT, Google Play Data Safety, and App Store privacy labels must be considered.
- compatibility_target: iOS 15+, iPhone SE 2/3, iPhone 12/13 mini, iPhone 15/15 Pro including notch/Dynamic Island safe area, Android 10+ representative devices, and WebGL desktop browser.
- output_expectation: Every stage must produce bounded Markdown handoffs, Notion-readable documents, Git-publishable artifacts, Unity source, Unity QA probe, Unity test evidence, local build validation, and local-agent QA result JSON. Handoff, heartbeat, BLOCKED, NO_REPLY, malformed output, missing evidence, or missing path must make the stage fail.
