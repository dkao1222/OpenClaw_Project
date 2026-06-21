# Manual Local Unity Build

This build row is monitor-only. The watcher must not launch Unity.

Run this command manually from `/Users/dragonkao/.openclaw` when Unity license/editor state is ready:

```bash
python3 scripts/run_game_build_pipeline.py --run-id notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245 --project-name NeonDrift_MVP --channel-id 386b9e33-8429-817f-84c3-d7f2769adc34 --stage-range build-ios-simulator --source-output-folder /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/ --source-handoff-path /home/node/.openclaw/workspace/386b9e33-8429-815b-b132-fb63e00fe3a9/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621150132/project/handoffs/development/final_handoff.md --output-folder /home/node/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/
```

Optional: add `--unity-path /path/to/Unity` if auto-detection picks the wrong editor.

Expected report: /home/node/.openclaw/workspace/386b9e33-8429-817f-84c3-d7f2769adc34/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-ios-simulator-20260621150245/project/status/validation/build_full_validation.md

The build watcher will mark the Notion row finished only after that report exists and contains `- status: passed` or `- status: failed`.
