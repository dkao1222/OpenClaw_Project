# NeonDrift iOS Simulator Crash RCA

## Incident
- Crash report time: 2026-06-25 00:52:12 +0800
- App: NeonDrift / com.DefaultCompany.NeonDrift
- Exception: EXC_BREAKPOINT (SIGTRAP)
- Triggered thread: Loading.PreloadManager
- Relevant stack: Unity scene preload / `CachedReader::OutOfBoundsError` while reading serialized scene objects.

## Root Cause
The generated Unity scene contained serialized runtime UI/gameplay objects with an invalid script reference. Build logs showed:

```text
Script attached to 'Gameplay HUD Root' in scene 'Assets/Scenes/Main.unity' is missing or no valid script is attached.
```

That broken scene serialization could pass build-time checks but crash during iOS simulator scene preload.

## Fix Applied
- Changed the generated Unity scene to a minimal scene container.
- Runtime gameplay/UI objects are now created by `NeonDriftRuntimeBootstrap.EnsureRuntimeScene()` after scene load.
- QA now clears stale simulator probes before every run and only accepts fresh runtime probes.
- QA now auto-boots an iPhone simulator when none is booted.
- QA now records live simulator screenshots, video, and runtime probes for gameplay, game-over, and retry states.

## Current Verification
- Build validation: passed.
- iOS simulator QA: passed.
- QA checks: 125 total, 0 failed, 0 blocked.
- Evidence video: `status/qa/evidence/simulator_playthrough.mp4`.
- Current logs show no `SIGTRAP`, `EXC_BREAKPOINT`, `scene-creation-failed`, or `CachedReader` crash after the fix.

## Remaining Product Risk
The crash is fixed, but QA pass only means the current technical gate passes. Game quality depth and visual richness should still be strengthened at define/planning/spec review level.
