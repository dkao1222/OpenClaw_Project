# Raw Idea

raw_idea_page_id: 389b9e33-8429-81f9-aac9-eac820cdd704
project_name: NeonDrift_MVP
idea_type: game
target_platform: Unity iOS
priority: high
requested_by: codex-clean-retry-from-raw

## Raw Idea（原始想法）

建立 NeonDrift_MVP，一款 iOS-first Unity 霓虹 arcade drifting 手機遊戲，用來完整驗證 OpenClaw pipeline。
需求必須從 Raw Idea 正規化到 Define，再進 Planning 0-12、Spec Review、Development、Local Unity iOS Simulator Build、QA、Delivery。
Planning 與 Spec Review 必須先規劃遊戲深度與畫面華麗度，不能到 development 才補。必須明確定義 icon、字體、背景、特效、音效、haptics、HUD、按鍵尺寸/位置/safe area、相容性機種與效能目標。
Development 必須產出 Unity 6000.0.77f1 專案，支援 iOS simulator，本機 Unity batchmode 可以 build，不需要人工開 Unity Hub。
QA 必須包含但不限於：按鍵是否可點、Start/Retry/Pause/Left/Right 功能、畫面是否可理解、遊戲物件是否有動態、玩家是否知道怎麼玩、早期 drift lost 是否合理、錄影/截圖/evidence、Unity Test Runner 結果。
Build row 應由 watcher/host runner 自動從 not start 開始，不需要人工改成 processing。
